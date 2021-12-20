using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClientApi
{
    public class Registry : IEnumerable<Page>
    {
        Instance instance;

        public uint CountOfEditableCardsWithNotifications { get; }
        public uint CountOfEditableCardsWithoutNotifications { get; }
        public uint CountOfOtherCards { get; }


        /// Этот конструктор должен вызываться в пределах неймспейса `ClientApi`.
        internal Registry(Instance instance, Filter? filter, Sorting? sorting)
        {
            this.instance = instance;
        }

        public IEnumerator<Page> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


    public class FilterBuilder
    {
        FilterStatuses filterStatuses;

        public FilterBuilder()
        {
            filterStatuses = new FilterStatuses();
            CardIdRange = Range.All;
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

        public Range CardIdRange { get; set; }
        public bool AttachedPdf { get; set; }
        public bool Commented { get; set; }

        public void Reset()
        {
            EditableCardsWithNotifications = false;
            EditableCardsWithoutNotifications = false;
            OtherCards = false;

            filterStatuses.Reset();

            AttachedPdf = false;
            Commented = false;
        }

        public Filter Build()
        {
            throw new NotImplementedException();
        }
    }

    public class FilterStatuses
    {
        /// Эти поля должны вызываться в пределах неймспейса `ClientApi`.
        internal bool submittedForRevision = false;
        internal bool draft = false;
        internal bool agreementByCatchingOrganization = false;
        internal bool agreedByCatchingOrganization = false;
        internal bool approvedByCatchingOrganization = false;
        internal bool agreedByOmsu = false;
        internal bool approvedByOmsu = false;

        /// Этот конструктор должен вызываться в пределах неймспейса `ClientApi`.
        internal FilterStatuses() { }

        public bool this[Status status]
        {
            get
            {
                // TODO: Сделать это иначе
                switch (status)
                {
                    case Status.SubmittedForRevision:
                        return submittedForRevision;
                    case Status.Draft:
                        return draft;
                    case Status.AgreementByCatchingOrganization:
                        return agreementByCatchingOrganization;
                    case Status.AgreedByCatchingOrganization:
                        return agreedByCatchingOrganization;
                    case Status.ApprovedByCatchingOrganization:
                        return approvedByCatchingOrganization;
                    case Status.AgreedByOmsu:
                        return agreedByOmsu;
                    case Status.ApprovedByOmsu:
                        return approvedByOmsu;
                    default:
                        throw new Exception();
                }
            }
            set
            {
                // TODO: Сделать это иначе
                switch (status)
                {
                    case Status.SubmittedForRevision:
                        submittedForRevision = value;
                        break;
                    case Status.Draft:
                        draft = value;
                        break;
                    case Status.AgreementByCatchingOrganization:
                        agreementByCatchingOrganization = value;
                        break;
                    case Status.AgreedByCatchingOrganization:
                        agreedByCatchingOrganization = value;
                        break;
                    case Status.ApprovedByCatchingOrganization:
                        approvedByCatchingOrganization = value;
                        break;
                    case Status.AgreedByOmsu:
                        agreedByOmsu = value;
                        break;
                    case Status.ApprovedByOmsu:
                        approvedByOmsu = value;
                        break;
                    default:
                        throw new Exception();
                }
            }
        }

        /// Этот метод должен вызываться в пределах неймспейса `ClientApi`.
        internal void Reset()
        {
            submittedForRevision = false;
            draft = false;
            agreementByCatchingOrganization = false;
            agreedByCatchingOrganization = false;
            approvedByCatchingOrganization = false;
            agreedByOmsu = false;
            approvedByOmsu = false;
        }
    }

    // Параметры фильтра, спарсенные в представление протокола
    public class Filter { }


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
            throw new NotImplementedException();
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
    public class Sorting { }


    public class Page : IEnumerable<CardCover>
    {
        Instance instance;

        /// Этот конструктор должен вызываться в пределах неймспейса `ClientApi`.
        internal Page(Instance instance)
        {
            this.instance = instance;
        }

        public IEnumerator<CardCover> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


    public class CardCover
    {
        Instance Instance;

        public uint CardId { get; private set; }
        public Status Status { get; private set; }
        public DateTime StatusChangeDate { get; private set; }
        public string CatchLocality { get; private set; }
        public DateTime CatchDate { get; private set; }
        public bool IsPdfAttached { get; private set; }
        public bool IsCommented { get; private set; }

        /// Этот конструктор должен вызываться в пределах неймспейса `ClientApi`.
        internal CardCover(Instance Instance, uint cardId, Status status, DateTime statusChangeDate,
            string locality, DateTime catchDate, bool isPdfAttached, bool isCommented)
        {
            CardId = cardId;
            Status = status;
            StatusChangeDate = statusChangeDate;
            CatchLocality = locality;
            CatchDate = catchDate;
            IsPdfAttached = isPdfAttached;
            IsCommented = isCommented;
        }
    }
}
