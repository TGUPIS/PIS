using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClientApi;

namespace PIS
{
    public partial class FilterPanel : UserControl
    {
        public Form1 form1;

        int countOfEditableCardsWithNotifications;
        public int CountOfEditableCardsWithNotifications
        {
            get
            {
                return countOfEditableCardsWithNotifications;
            }
            set
            {
                countOfEditableCardsWithNotifications = value;
                countOfOfEditableCardsWithNotificationsBox.Text = "(" + value + ")";
            }
        }

        int countOfEditableCardsWithoutNotifications;
        public int CountOfEditableCardsWithoutNotifications
        {
            get
            {
                return countOfEditableCardsWithoutNotifications;
            }
            set
            {
                countOfEditableCardsWithoutNotifications = value;
                countOfEditableCardsWithoutNotificationsBox.Text = "(" + value + ")";
            }
        }

        int countOfOtherCards;
        public int CountOfOtherCards
        {
            get
            {
                return countOfOtherCards;
            }
            set
            {
                countOfOtherCards = value;
                countOfOtherCardsBox.Text = "(" + value + ")";
            }
        }
        
        public FilterPanel()
        {
            InitializeComponent();

            Reset();
        }

        void Reset()
        {
            var sortingBuilder = new SortingBuilder();
            var filterBuilder = new FilterBuilder();

            sortingBuilder.Reset();

            sortingByBox.SelectedIndex = sortingBuilder.SortingBy switch
            {
                SortingBy.StatusChangeDateTime => 0,
                SortingBy.CatchDate => 1,
                SortingBy.CardId => 2,
                _ => throw new Exception()
            };
            orderByBox.SelectedIndex = sortingBuilder.OrderBy switch
            {
                OrderBy.Descending => 0,
                OrderBy.Ascending => 1,
                _ => throw new Exception()
            };

            filterBuilder.Reset();

            checkBoxOfEditableCardsWithNotifications.Checked = filterBuilder.EditableCardsWithNotifications;
            checkBoxOfEditableCardsWithoutNotifications.Checked = filterBuilder.EditableCardsWithoutNotifications;
            checkBoxOfOtherCards.Checked = filterBuilder.OtherCards;

            checkBoxOfDraft.Checked = filterBuilder.FilterStatuses[Status.Draft];
            checkBoxOfAgreementByCatchingOrganization.Checked
                = filterBuilder.FilterStatuses[Status.AgreementByCatchingOrganization];
            checkBoxOfAgreedByCatchingOrganization.Checked
                = filterBuilder.FilterStatuses[Status.AgreedByCatchingOrganization];
            checkBoxOfApprovedByCatchingOrganization.Checked
                = filterBuilder.FilterStatuses[Status.ApprovedByCatchingOrganization];
            checkBoxOfAgreedByOmsu.Checked = filterBuilder.FilterStatuses[Status.AgreedByOmsu];
            checkBoxOfApprovedByOmsu.Checked = filterBuilder.FilterStatuses[Status.ApprovedByOmsu];

            CardIdRangeStart.Text = "";
            CardIdRangeEnd.Text = "";

            checkBoxOfCommented.Checked = filterBuilder.IsCommented;
            checkBoxOfAttachedPdf.Checked = filterBuilder.IsPdfAttached;
        }

        private void CardIdRangeStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CardIdRangeEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            var sortingBuilder = new SortingBuilder();
            var filterBuilder = new FilterBuilder();

            sortingBuilder.SortingBy = sortingByBox.SelectedIndex switch
            {
                0 => SortingBy.StatusChangeDateTime,
                1 => SortingBy.CatchDate,
                2 => SortingBy.CardId,
                _ => throw new Exception()
            };
            sortingBuilder.OrderBy = orderByBox.SelectedIndex switch
            {
                0 => OrderBy.Descending,
                1 => OrderBy.Ascending,
                _ => throw new Exception()
            };

            filterBuilder.EditableCardsWithNotifications = checkBoxOfEditableCardsWithNotifications.Checked;
            filterBuilder.EditableCardsWithoutNotifications = checkBoxOfEditableCardsWithoutNotifications.Checked;
            filterBuilder.OtherCards = checkBoxOfOtherCards.Checked;

            filterBuilder.FilterStatuses[Status.Draft] = checkBoxOfDraft.Checked;
            filterBuilder.FilterStatuses[Status.AgreementByCatchingOrganization]
                = checkBoxOfAgreementByCatchingOrganization.Checked;
            filterBuilder.FilterStatuses[Status.AgreedByCatchingOrganization]
                = checkBoxOfAgreedByCatchingOrganization.Checked;
            filterBuilder.FilterStatuses[Status.ApprovedByCatchingOrganization]
                = checkBoxOfApprovedByCatchingOrganization.Checked;
            filterBuilder.FilterStatuses[Status.AgreedByOmsu] = checkBoxOfAgreedByOmsu.Checked;
            filterBuilder.FilterStatuses[Status.ApprovedByOmsu] = checkBoxOfApprovedByOmsu.Checked;

            filterBuilder.IsCommented = checkBoxOfCommented.Checked;
            filterBuilder.IsPdfAttached = checkBoxOfAttachedPdf.Checked;

            (int? start, int? end)? cardIdRange = GetCardNumberRange();
            if (!cardIdRange.HasValue)
                return;
            filterBuilder.CardIdRangeStart = cardIdRange.Value.start;
            filterBuilder.CardIdRangeEnd = cardIdRange.Value.end;

            form1.Filter = filterBuilder.Build(form1.instance);
            form1.Sorting = sortingBuilder.Build(form1.instance);
            form1.UpdateCardCovers(1);
        }


        (int?, int?)? GetCardNumberRange()
        {
            try
            {
                int? cardIdRangeStart = null;
                if (CardIdRangeStart.Text != "")
                {
                    cardIdRangeStart = Int32.Parse(CardIdRangeStart.Text);
                }

                int? cardIdRangeEnd = null;
                if (CardIdRangeEnd.Text != "")
                {
                    cardIdRangeEnd = Int32.Parse(CardIdRangeEnd.Text);
                }

                if (cardIdRangeStart.HasValue && cardIdRangeEnd.HasValue
                    && cardIdRangeStart.Value > cardIdRangeEnd.Value)
                {
                    MessageBox.Show("Неправильный формат, начальное число должно быть не более конечного числа");
                    return null;
                }

                if (cardIdRangeStart.HasValue && cardIdRangeStart.Value < 1
                    || cardIdRangeEnd.HasValue && cardIdRangeEnd.Value < 1)
                {
                    MessageBox.Show("Неправильный формат, начальное и конечное числа должны быть не менее 1");
                    return null;
                }

                return (cardIdRangeStart, cardIdRangeEnd);

            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильный формат, ввести можно только числа");
                return null;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
