using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApi
{
    public class CardContent
    {
        public int CardId { get; }

        /// Этот конструктор должен вызываться в пределах неймспейса `ClientApi`.
        internal CardContent(int cardId)
        {
            CardId = cardId;
        }
    }


    public class EditableCard
    {
        Instance instance;

        Status[] statuses;
        int currentStatusIndex;

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
                return statuses[currentStatusIndex];
            }
        }

        /// Этот конструктор должен вызываться в пределах неймспейса `ClientApi`.
        internal EditableCard(Instance instance, int cardId, Status[] statuses, int currentStatusIndex)
        {
            this.instance = instance;
            CardId = cardId;
            this.statuses = statuses;
            this.currentStatusIndex = currentStatusIndex;
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

        /// Сохраняет изменения карточки на сервере. Если соединение с сервером не удалось, бросает `ConnectionException`.
        public void Save() { }

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
}
