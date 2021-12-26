using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;

namespace ClientApi
{
    /// Точка входа клиентского приложения на бэкенд.
    public class Instance
    {
        /// Это поле должно вызываться в пределах неймспейса `ClientApi`.
        internal int roleId = 2;


        string sqlString = @"Data Source=localhost;Initial Catalog=Animals;Integrated Security=True";

        /// Это поле должно вызываться в пределах неймспейса `ClientApi`.
        internal SqlConnection connection;

        public ProtocolVersion ProtocolVersion { get; }

        public Instance()
        {
            connection = new SqlConnection(sqlString);
        }

        /// Текущий метод нигде не сохраняет `Filter` и `Sorting`, использует их только для чтения
        public Registry GetRegistry(Filter filter, Sorting sorting)
        {
            return new Registry(this, filter, sorting, roleId);
        }

        public CardContent OpenCard(CardCover cardCover)
        {

            var version = GetCardVersion(connection, cardCover.CardId);
            return new CardContent(cardCover.CardId, cardCover.CurrentStatus, version);
        }

        /// Этот метод должен вызываться в пределах неймспейса `ClientApi`.
        internal static int GetCardVersion(SqlConnection sqlConnection, int cardId)
        {
            var sql = $@"
SELECT version
    FROM Card
    WHERE id = {cardId}";
            var sqlCommand = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();
            var result = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();

            return result;
        }

        public EditableCard EditCard(CardContent cardContent)
        {
            var statusIds = GetEditStatuses(cardContent.CurrentStatus);
            var currentStatusIndex = statusIds.IndexOf(cardContent.CurrentStatus);
            return new EditableCard(this, cardContent.CardId, statusIds.ToArray(),
                currentStatusIndex, cardContent.version);
        }

        List<Status> GetEditStatuses(Status currentStatus)
        {
            var sql = $@"
SELECT new_status_id, sorting_order
    FROM get_new_statuses_of_card({roleId}, {(int)currentStatus})
    UNION SELECT id, sorting_order FROM Status WHERE id = {(int)currentStatus}
    ORDER BY sorting_order ASC;";
            var sqlCommand = new SqlCommand(sql, connection);

            connection.Open();

            var statusIds = new List<Status>();
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var statusId = (Status)reader.GetInt32(0);
                    statusIds.Add(statusId);
                }
            }

            connection.Close();

            return statusIds;
        }
    }

    public enum ProtocolVersion
    {
        V0x1
    }


    public class ConnectionException : Exception { }
}
