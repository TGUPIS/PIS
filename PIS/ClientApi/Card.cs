using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ClientApi
{
    public class CardContent
    {
        public int CardId { get; private set; }
        public Status CurrentStatus { get; private set; }

        /// Это поле должно вызываться в пределах неймспейса `ClientApi`.
        internal int version;

        /// Этот конструктор должен вызываться в пределах неймспейса `ClientApi`.
        internal CardContent(int cardId, Status currentStatus, int version)
        {
            CardId = cardId;
            CurrentStatus = currentStatus;
            this.version = version;
        }
    }


    public class EditableCard
    {
        Instance instance;

        Status[] statuses;
        int currentStatusIndex;
        int defaultStatusIndex;

        int version;

        public int CardId { get; private set; }

        /// Можно ли отправить карточку на следующую стадию?
        public bool IsCardSentToNextStage
        {
            get
            {
                return currentStatusIndex + 1 < statuses.Length;
            }
        }

        /// Можно ли отправить карточку на предыдущую стадию?
        public bool IsCardSentToPreviousStage
        {
            get
            {
                return currentStatusIndex >= 1;
            }
        }

        public Status CurrentCardStage
        {
            get
            {
                return statuses[currentStatusIndex];
            }
        }

        /// Этот конструктор должен вызываться в пределах неймспейса `ClientApi`.
        internal EditableCard(Instance instance, int cardId, Status[] statuses, int currentStatusIndex, int version)
        {
            this.instance = instance;
            CardId = cardId;
            this.statuses = statuses;
            this.currentStatusIndex = this.defaultStatusIndex = currentStatusIndex;
            this.version = version;
        }

        /// Отправляет карточку на следующую стадию. Если `IsCardSentToNextStage == false`,
        /// бросает `InvalidOperationException`.
        public void SendCardToNextStage()
        {
            if (!IsCardSentToNextStage)
                throw new InvalidOperationException();

            currentStatusIndex += 1;
        }

        /// Отправляет карточку на предыдущую стадию. Если `IsCardSentToNextStage == false`, бросает `InvalidOperationException`.
        public void SendCardToPreviousStage()
        {
            if (!IsCardSentToPreviousStage)
                throw new InvalidOperationException();

            currentStatusIndex -= 1;
        }

        /// Сохраняет изменения карточки на сервере.
        /// Если карточку невозможно сохранить из-за одновременного сохранения многими пользователями,
        /// бросает `InvalidConcurrentSaveException`.
        /// Если соединение с сервером не удалось, бросает `ConnectionException`.
        public void Save()
        {
            if (currentStatusIndex == defaultStatusIndex)
                return;

            var newVersion = Instance.GetCardVersion(instance.connection, CardId);
            if (version != newVersion)
                throw new InvalidConcurrentSaveException();

            var sqlStatusUpdate = $@"
INSERT INTO StatusHistory VALUES ({CardId}, CURRENT_TIMESTAMP, NULL, {(int)statuses[currentStatusIndex]});";
            var sqlStatusUpdateCommand = new SqlCommand(sqlStatusUpdate, instance.connection);

            var sqlVersionUpdate = $@"
 UPDATE Card SET version += 1 WHERE id = {CardId};";
            var sqlVersionUpdateCommand = new SqlCommand(sqlVersionUpdate, instance.connection);

            instance.connection.Open();

            // Обновить статус
            var statusIds = new List<Status>();
            using (SqlDataReader reader = sqlStatusUpdateCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var statusId = (Status)reader.GetInt32(0);
                    statusIds.Add(statusId);
                }
            }

            // Обновить версию
            sqlVersionUpdateCommand.ExecuteNonQuery();

            instance.connection.Close();
        }


        /// Отменяет изменения карточки, получив актуальные данные с сервера. Если соединение с сервером не удалось, бросает `ConnectionException`.
        public void Reset() { }
    }


    public enum Status
    {
        // Черновик
        Draft = 1,
        // Согласование в организации по отлову
        AgreementByCatchingOrganization = 2,
        // Согласовано в организации по отлову
        AgreedByCatchingOrganization = 3,
        // Утверждено в организации по отлову
        ApprovedByCatchingOrganization = 4,
        // Согласовано в ОМСУ
        AgreedByOmsu = 5,
        // Утверждено в ОМСУ
        ApprovedByOmsu = 6
    }

    public class InvalidConcurrentSaveException : Exception
    {
        public InvalidConcurrentSaveException() { }
    }
}
