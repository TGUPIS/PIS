using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ClientApi
{
    /// Точка входа клиентского приложения на бэкенд.
    public class Instance
    {
        string sqlString = @"Data Source=localhost;Initial Catalog=Animals;Integrated Security=True";

        /// Это поле должно вызываться в пределах неймспейса `ClientApi`.
        internal SqlConnection connection;

        public ProtocolVersion ProtocolVersion { get; }

        public Instance() {
            connection = new SqlConnection(sqlString);






            /*
            var command = new SqlCommand("SELECT role_id, status_id FROM StatusChangeNotificationRoles", connection);

            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    System.Windows.Forms.MessageBox.Show(String.Format("{0}, {1}",
                        reader[0], reader[1]));
                }
            }
            connection.Close();
            */
        }

        /// Текущий метод нигде не сохраняет `Filter` и `Sorting`, использует их только для чтения
        public Registry GetRegistry(Filter filter, Sorting sorting)
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
