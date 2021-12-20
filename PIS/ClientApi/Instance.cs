using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApi
{
    /// Точка входа клиентского приложения на бэкенд.
    public class Instance
    {
        public ProtocolVersion ProtocolVersion { get; }

        public Instance() { }

        /// Текущий метод нигде не сохраняет `Filter` и `Sorting`, использует их только для чтения
        public Registry GetRegistry(Filter? filter, Sorting? sorting)
        {
            return new Registry(this, filter, sorting);
        }

        public CardContent OpenCard(CardCover cardCover)
        {
            return new CardContent(cardCover.CardId);
        }

        public EditableCard EditCard(CardContent cardContent)
        {
            return new EditableCard(this, cardContent.CardId, new Status[] { Status.SubmittedForRevision,
                Status.AgreedByCatchingOrganization, Status.ApprovedByCatchingOrganization }, 1);
        }
    }

    public enum ProtocolVersion
    {
        V0x1
    }


    public class ConnectionException { }
}
