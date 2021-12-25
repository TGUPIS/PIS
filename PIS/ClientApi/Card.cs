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
        internal DataBaseStatus CurrentDataBaseStatus { get; private set; }

        /// Это поле должно вызываться в пределах неймспейса `ClientApi`.
        internal int version;

        /// Этот конструктор должен вызываться в пределах неймспейса `ClientApi`.
        internal CardContent(int cardId, Status currentStatus, DataBaseStatus currentDataBaseStatus, int version)
        {
            CardId = cardId;
            CurrentStatus = currentStatus;
            CurrentDataBaseStatus = currentDataBaseStatus;
            this.version = version;
        }
    }


    public class EditableCard
    {
        Instance instance;

        DataBaseStatus[] statuses;
        int currentStatusIndex;
        int defaultStatusIndex;

        int version;

        public int CardId { get; private set; }

        /// Можно ли отправить карточку на следующую стадию?
        public bool IsCardSentToNextStage {
            get
            {
                return currentStatusIndex + 1 < statuses.Length;
            }
        }

        /// Можно ли отправить карточку на предыдущую стадию?
        public bool IsCardSentToPreviousStage {
            get
            {
                return currentStatusIndex >= 1;
            }
        }

        public Status CurrentCardStage {
            get
            {
                return FilterBuilder.ConvertDataBaseStatus(statuses[currentStatusIndex]);
            }
        }

        internal DataBaseStatus CurrentDataBaseStatus
        {
            get
            {
                return statuses[currentStatusIndex];
            }
        }

        /// Этот конструктор должен вызываться в пределах неймспейса `ClientApi`.
        internal EditableCard(Instance instance, int cardId, DataBaseStatus[] statuses, int currentStatusIndex, int version)
        {
            this.instance = instance;
            CardId = cardId;
            this.statuses = statuses;
            this.currentStatusIndex = this.defaultStatusIndex = currentStatusIndex;
            this.version = version;
        }

        /// Отправляет карточку на следующую стадию. Если `IsCardSentToNextStage == false`,
        /// бросает `InvalidOperationException`.
        public void SendCardToNextStage() {
            if (!IsCardSentToNextStage)
                throw new InvalidOperationException();

            currentStatusIndex += 1;
        }

        /// Отправляет карточку на предыдущую стадию. Если `IsCardSentToNextStage == false`, бросает `InvalidOperationException`.
        public void SendCardToPreviousStage() {
            if (!IsCardSentToPreviousStage)
                throw new InvalidOperationException();

            currentStatusIndex -= 1;
        }

        /// Сохраняет изменения карточки на сервере.
        /// Если карточку невозможно сохранить из-за одновременного сохранения многими пользователями,
        /// бросает `InvalidConcurrentSaveException`.
        /// Если соединение с сервером не удалось, бросает `ConnectionException`.
        public void Save() {
            if (currentStatusIndex == defaultStatusIndex)
                return;

            var newVersion = Instance.GetCardVersion(instance.connection, CardId);
            if(version != newVersion)
                throw new InvalidConcurrentSaveException();

            var sql = $@"
INSERT INTO StatusHistory VALUES ({CardId}, CURRENT_TIMESTAMP, NULL, {(int)statuses[currentStatusIndex]});";
            var sqlCommand = new SqlCommand(sql, instance.connection);

            instance.connection.Open();

            var statusIds = new List<Status>();
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var statusId = (Status)reader.GetInt32(0);
                    statusIds.Add(statusId);
                }
            }

            instance.connection.Close();
        }

        /// Отменяет изменения карточки, получив актуальные данные с сервера. Если соединение с сервером не удалось, бросает `ConnectionException`.
        public void Reset() { }
    }


    public enum Status
    {
        // Отправлено на доработку
        SubmittedForRevision = 1,
        // Черновик
        Draft = 2,
        // Согласование в организации по отлову
        AgreementByCatchingOrganization = 3,
        // Согласовано в организации по отлову
        AgreedByCatchingOrganization = 4,
        // Утверждено в организации по отлову
        ApprovedByCatchingOrganization = 5,
        // Согласовано в ОМСУ
        AgreedByOmsu = 6,
        // Утверждено в ОМСУ
        ApprovedByOmsu = 7
    }

    internal enum DataBaseStatus
    {
        // Отправлено на доработку: Черновик
        SubmittedForRevisionToDraft = 1,
        // Отправлено на доработку: Согласование в организации по отлову
        SubmittedForRevisionToAgreementByCatchingOrganization = 2,
        // Отправлено на доработку: Согласовано в организации по отлову
        SubmittedForRevisionToAgreedByCatchingOrganization = 3,
        // Отправлено на доработку: Утверждено в организации по отлову
        SubmittedForRevisionToApprovedByCatchingOrganization = 4,
        // Отправлено на доработку: Согласовано в ОМСУ
        SubmittedForRevisionToAgreedByOmsu = 5,
        // Отправлено на доработку: Утверждено в ОМСУ
        SubmittedForRevisionToApprovedByOmsu = 6,
        // Черновик
        Draft = 7,
        // Согласование в организации по отлову
        AgreementByCatchingOrganization = 8,
        // Согласовано в организации по отлову
        AgreedByCatchingOrganization = 9,
        // Утверждено в организации по отлову
        ApprovedByCatchingOrganization = 10,
        // Согласовано в ОМСУ
        AgreedByOmsu = 11,
        // Утверждено в ОМСУ
        ApprovedByOmsu = 12
    }

    public class InvalidConcurrentSaveException : Exception
    {
        public InvalidConcurrentSaveException() { }
    }
}
