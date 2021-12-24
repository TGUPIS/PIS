using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;

namespace ClientApi
{
    public class Registry
    {
        Instance instance;
        Filter filter;
        Sorting sorting;
        const int pageLength = 10;


        int roleId = 1;


        public int CountOfEditableCardsWithNotifications { get; private set; }
        public int CountOfEditableCardsWithoutNotifications { get; private set; }
        public int CountOfOtherCards { get; private set; }

        public int PageCount { get; private set; }

        internal Registry(Instance instance, Filter filter, Sorting sorting)
        {
            this.instance = instance;
            this.filter = filter;
            this.sorting = sorting;

            PageCount = GetPageCount();
            CountOfEditableCardsWithNotifications
                = GetNotificationCount(NotificationType.EditableCardsWithNotifications);
            CountOfEditableCardsWithoutNotifications
                = GetNotificationCount(NotificationType.EditableCardsWithoutNotifications);
            CountOfOtherCards
                = GetNotificationCount(NotificationType.OtherCards);
        }

        int GetPageCount()
        {
            var sqlcardCoverCount =
                "SELECT COUNT(*) FROM Card JOIN get_last_status_of_cards() x ON id = x.card_id"
                + " " + filter.sql
                + ";";
            var pageCountCommand = new SqlCommand(sqlcardCoverCount, instance.connection);

            instance.connection.Open();
            var cardCoverCount = (int)pageCountCommand.ExecuteScalar();
            instance.connection.Close();

            return cardCoverCount / pageLength + cardCoverCount % pageLength != 0 ? 1 : 0;
        }

        int GetNotificationCount(NotificationType notificationType)
        {
            var sqlFunctionName = notificationType switch
            {
                NotificationType.EditableCardsWithNotifications
                    => "get_card_role_statuses_of_edit_with_notification",
                NotificationType.EditableCardsWithoutNotifications
                    => "get_card_role_statuses_of_edit_without_notification",
                NotificationType.OtherCards
                    => "get_card_role_statuses_of_other_cards",
                _ => throw new Exception()
            };

            var sql = $@"
SELECT COUNT(*)
    FROM get_last_status_of_cards() s
    JOIN {sqlFunctionName}({roleId}) t ON s.status_id = t.status_id;";
            var sqlCommand = new SqlCommand(sql, instance.connection);

            instance.connection.Open();
            var result = (int)sqlCommand.ExecuteScalar();
            instance.connection.Close();

            return result;
        }


        /// Номера страниц начинаются с единицы
        public Page this[int pageNumber]
        {
            get
            {
                if (pageNumber < 1)
                    throw new ArgumentException();

                var cardCovers = new List<CardCover>(pageLength);

                var sqlQuery = @"
SELECT x.card_id, x.status_id, x.status_change_datetime, catchLocality, catchDate,
    CASE WHEN pdf IS NULL THEN 'False' ELSE 'True' END isPdfAttached,
    CASE WHEN comment IS NULL THEN 'False' ELSE 'True' END isCommented
	FROM Card
	JOIN get_last_status_of_cards() x
	ON id = x.card_id"
                    + " " + filter.sql
                    + " " + sorting.sql
                    + " " + @$"OFFSET {(pageNumber - 1) * pageLength} ROWS
FETCH NEXT {pageLength} ROWS ONLY"
                    + ";";

                var queryCommand = new SqlCommand(sqlQuery, instance.connection);

                instance.connection.Open();

                using (SqlDataReader reader = queryCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cardCover = new CardCover(
                            instance,
                            reader.GetInt32(0),
                            (Status)reader.GetInt32(1),
                            reader.GetDateTime(2),
                            reader.GetString(3),
                            reader.GetDateTime(4),
                            Boolean.Parse(reader.GetString(5)),
                            Boolean.Parse(reader.GetString(6)));

                        cardCovers.Add(cardCover);
                    }
                }

                instance.connection.Close();

                return new Page(instance, cardCovers);
            }
        }
    }


    public class FilterBuilder
    {
        FilterStatuses filterStatuses;

        public FilterBuilder()
        {
            filterStatuses = new FilterStatuses();
            Reset();
        }

        public FilterStatuses FilterStatuses
        {
            get
            {
                return filterStatuses;
            }
        }

        public bool EditableCardsWithNotifications { get; set; }
        public bool EditableCardsWithoutNotifications { get; set; }
        public bool OtherCards { get; set; }

        int? cardIdRangeStart;
        public int? CardIdRangeStart {
            get
            {
                return cardIdRangeStart;
            }
            set
            {
                if(value.HasValue && (CardIdRangeEnd.HasValue && value.Value > CardIdRangeEnd.Value
                    || value.Value < 1))
                    throw new ArgumentException();

                cardIdRangeStart = value;
            }
        }
        int? cardIdRangeEnd;
        public int? CardIdRangeEnd
        {
            get
            {
                return cardIdRangeEnd;
            }
            set
            {
                if (value.HasValue && (CardIdRangeStart.HasValue && value.Value < CardIdRangeStart.Value
                    || value.Value < 1))
                    throw new ArgumentException();

                cardIdRangeEnd = value;
            }
        }
        public bool IsPdfAttached { get; set; }
        public bool IsCommented { get; set; }

        public void Reset()
        {
            EditableCardsWithNotifications = false;
            EditableCardsWithoutNotifications = false;
            OtherCards = false;            

            filterStatuses.Reset();

            CardIdRangeStart = null;
            CardIdRangeEnd = null;

            IsPdfAttached = false;
            IsCommented = false;
        }

        public Filter Build()
        {
            const int roleId = 1;

            var statuses = String.Join(" OR ",
                filterStatuses.statuses
                    .Select((x, i) => (x, i)).Where(t => t.x).Select(t => $"x.status_id = {t.i + 1}"));
            var rangeStart = CardIdRangeStart.HasValue ? $"x.card_id >= {CardIdRangeStart.Value}" : "";
            var rangeEnd = CardIdRangeEnd.HasValue ? $"x.card_id <= {CardIdRangeEnd.Value}" : "";
            var isPdfAttached = IsPdfAttached ? @"pdf IS NOT NULL" : "";
            var isCommented = IsCommented ? @"comment IS NOT NULL" : "";

            var roleStatusesOfCardEditWithNotification
                = $"SELECT status_id FROM get_card_role_statuses_of_edit_with_notification({roleId})";

            var roleStatusesOfCardEditWithoutNotification
                = $"SELECT status_id FROM get_card_role_statuses_of_edit_without_notification({roleId})";

            var otherCardStatuses = $"SELECT status_id FROM get_card_role_statuses_of_other_cards({roleId})";

            var cardTypes = String.Join(" UNION ", new string[]
            {
                EditableCardsWithNotifications ? roleStatusesOfCardEditWithNotification : "",
                EditableCardsWithoutNotifications ? roleStatusesOfCardEditWithoutNotification : "",
                OtherCards ? otherCardStatuses : ""
            }.Where(x => x != ""));
            if (cardTypes != "")
                cardTypes = $"x.status_id IN ({cardTypes})";

            var sql = String.Join(" AND ", new string[]
            {
                cardTypes,
                statuses,
                rangeStart,
                rangeEnd,
                isPdfAttached,
                isCommented
            }.Where(x => x != "").Select(x => "(" + x + ")"));
            if (sql != "")
                sql = $"WHERE {sql}";

            return new Filter(sql);
        }
    }

    public class FilterStatuses
    {
        const int statusCount = 7;

        /// Это поле должно вызываться в пределах неймспейса `ClientApi`.
        /// `True` значит статус под таким индексом активен. Индекс статуса равен номеру этого статуса минус 1.
        internal bool[] statuses = new bool[statusCount];

        /// Этот конструктор должен вызываться в пределах неймспейса `ClientApi`.
        internal FilterStatuses() { }

        public bool this[Status status]
        {
            get
            {
                return statuses[(int)status - 1];
            }
            set
            {
                statuses[(int)status - 1] = value;
            }
        }

        /// Этот метод должен вызываться в пределах неймспейса `ClientApi`.
        internal void Reset()
        {
            for (int i = 0; i < statuses.Length; ++i)
                statuses[i] = false;
        }
    }

    // Параметры фильтра, спарсенные в представление протокола
    public class Filter
    {
        internal string sql;

        internal Filter(string sql)
        {
            this.sql = sql;
        }
    }


    public class SortingBuilder
    {
        public SortingBy SortingBy { get; set; }
        public OrderBy OrderBy { get; set; }

        public SortingBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            SortingBy = SortingBy.StatusChangeDateTime;
            OrderBy = OrderBy.Descending;
        }

        public Sorting Build()
        {
            var sql = SortingBy switch
            {
                SortingBy.StatusChangeDateTime => OrderBy switch
                {
                    OrderBy.Descending => @"ORDER BY x.status_change_datetime DESC, x.card_id ASC",
                    OrderBy.Ascending => @"ORDER BY x.status_change_datetime ASC, x.card_id ASC",
                    _ => throw new Exception()
                },
                SortingBy.CatchDate => OrderBy switch
                {
                    OrderBy.Descending => @"ORDER BY catchDate DESC, x.card_id ASC",
                    OrderBy.Ascending => @"ORDER BY catchDate ASC, x.card_id ASC",
                    _ => throw new Exception()
                },
                SortingBy.CardId => OrderBy switch
                {
                    OrderBy.Descending => @"ORDER BY x.card_id DESC, x.status_change_datetime DESC",
                    OrderBy.Ascending => @"ORDER BY x.card_id ASC, x.status_change_datetime DESC",
                    _ => throw new Exception()
                },
                _ => throw new Exception()
            };

            return new Sorting(sql);
        }
    }

    public enum SortingBy
    {
        CardId,
        CatchDate,
        StatusChangeDateTime
    }

    public enum OrderBy
    {
        Ascending,
        Descending
    }

    // Параметры сортировки, спарсенные в представление протокола
    public class Sorting
    {
        internal string sql;

        internal Sorting(string sql)
        {
            this.sql = sql;
        }
    }


    public class Page : IEnumerable<CardCover>
    {
        Instance instance;
        List<CardCover> cardCovers;

        /// Этот конструктор должен вызываться в пределах неймспейса `ClientApi`.
        internal Page(Instance instance, List<CardCover> cardCovers)
        {
            this.instance = instance;
            this.cardCovers = cardCovers;
        }

        public IEnumerator<CardCover> GetEnumerator()
        {
            return cardCovers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cardCovers.GetEnumerator();
        }
    }


    public class CardCover
    {
        Instance Instance;

        public int CardId { get; private set; }
        public Status Status { get; private set; }
        public DateTime StatusChangeDate { get; private set; }
        public string CatchLocality { get; private set; }
        public DateTime CatchDate { get; private set; }
        public bool IsPdfAttached { get; private set; }
        public bool IsCommented { get; private set; }

        /// Этот конструктор должен вызываться в пределах неймспейса `ClientApi`.
        internal CardCover(Instance Instance, int cardId, Status status, DateTime statusChangeDate,
            string catchLocality, DateTime catchDate, bool isPdfAttached, bool isCommented)
        {
            CardId = cardId;
            Status = status;
            StatusChangeDate = statusChangeDate;
            CatchLocality = catchLocality;
            CatchDate = catchDate;
            IsPdfAttached = isPdfAttached;
            IsCommented = isCommented;
        }
    }


    public enum NotificationType
    {
        EditableCardsWithNotifications,
        EditableCardsWithoutNotifications,
        OtherCards
    }
}
