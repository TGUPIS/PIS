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
        SortingBuilder sortingBuilder;
        FilterBuilder filterBuilder;
        public FilterPanel()
        {
            InitializeComponent();

            sortingBuilder = new SortingBuilder();
            filterBuilder = new FilterBuilder();
            Reset();
        }


        void Reset()
        {
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

            checkBoxOfSubmittedForRevision.Checked = filterBuilder.FilterStatuses[Status.SubmittedForRevision];
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

            checkBoxOfCommented.Checked = filterBuilder.Commented;
            checkBoxOfAttachedPdf.Checked = filterBuilder.AttachedPdf;
        }

        private void sortingByBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortingBuilder.SortingBy = sortingByBox.SelectedIndex switch
            {
                0 => SortingBy.StatusChangeDateTime,
                1 => SortingBy.CatchDate,
                2 => SortingBy.CardId,
                _ => throw new Exception()
            };
        }

        private void orderByBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortingBuilder.OrderBy = orderByBox.SelectedIndex switch
            {
                0 => OrderBy.Descending,
                1 => OrderBy.Ascending,
                _ => throw new Exception()
            };
        }

        private void checkBoxOfEditableCardsWithNotifications_CheckedChanged(object sender, EventArgs e)
        {
            filterBuilder.EditableCardsWithNotifications = (sender as CheckBox).Checked;
        }

        private void checkBoxOfEditableCardsWithoutNotifications_CheckedChanged(object sender, EventArgs e)
        {
            filterBuilder.EditableCardsWithoutNotifications = (sender as CheckBox).Checked;
        }

        private void checkBoxOfOtherCards_CheckedChanged(object sender, EventArgs e)
        {
            filterBuilder.OtherCards = (sender as CheckBox).Checked;
        }

        private void checkBoxOfSubmittedForRevision_CheckedChanged(object sender, EventArgs e)
        {
            filterBuilder.FilterStatuses[Status.SubmittedForRevision] = (sender as CheckBox).Checked;
        }

        private void checkBoxOfDraft_CheckedChanged(object sender, EventArgs e)
        {
            filterBuilder.FilterStatuses[Status.Draft] = (sender as CheckBox).Checked;
        }

        private void checkBoxOfAgreementByCatchingOrganization_CheckedChanged(object sender, EventArgs e)
        {
            filterBuilder.FilterStatuses[Status.AgreementByCatchingOrganization] = (sender as CheckBox).Checked;
        }

        private void checkBoxOfAgreedByCatchingOrganization_CheckedChanged(object sender, EventArgs e)
        {
            filterBuilder.FilterStatuses[Status.AgreedByCatchingOrganization] = (sender as CheckBox).Checked;
        }

        private void checkBoxOfApprovedByCatchingOrganization_CheckedChanged(object sender, EventArgs e)
        {
            filterBuilder.FilterStatuses[Status.ApprovedByCatchingOrganization] = (sender as CheckBox).Checked;
        }

        private void checkBoxOfAgreedByOmsu_CheckedChanged(object sender, EventArgs e)
        {
            filterBuilder.FilterStatuses[Status.AgreedByOmsu] = (sender as CheckBox).Checked;
        }

        private void checkBoxOfApprovedByOmsu_CheckedChanged(object sender, EventArgs e)
        {
            filterBuilder.FilterStatuses[Status.ApprovedByOmsu] = (sender as CheckBox).Checked;
        }

        private void checkBoxOfCommented_CheckedChanged(object sender, EventArgs e)
        {
            filterBuilder.Commented = (sender as CheckBox).Checked;
        }

        private void checkBoxOfAttachedPdf_CheckedChanged(object sender, EventArgs e)
        {
            filterBuilder.AttachedPdf = (sender as CheckBox).Checked;
        }

        private void CardIdRangeStart_TextChanged(object sender, EventArgs e)
        {
            var text = (sender as TextBox).Text;
            try
            {
                var parsed = Int32.Parse(text);
                if (CardIdRangeEnd.Text != "" && parsed > filterBuilder.CardIdRange.End.Value)
                {
                    // TODO: Убрать это, сделать заливку фона у текстбокса.
                    MessageBox.Show("Неправильный формат, начальное число должно быть не более конечного числа");
                    return;
                }
                filterBuilder.CardIdRange = new Range(new Index(parsed), filterBuilder.CardIdRange.End);

            }
            catch (FormatException)
            {
                // TODO: Убрать это, сделать заливку фона у текстбокса.
                MessageBox.Show("Неправильный формат, ввести можно только числа");
                return;
            }
        }

        private void CardIdRangeEnd_TextChanged(object sender, EventArgs e)
        {
            var text = (sender as TextBox).Text;
            try
            {
                var parsed = Int32.Parse(text);
                if(CardIdRangeStart.Text != "" && parsed < filterBuilder.CardIdRange.Start.Value)
                {
                    // TODO: Убрать это, сделать заливку фона у текстбокса.
                    MessageBox.Show("Неправильный формат, начальное число должно быть не более конечного числа");
                    return;
                }
                filterBuilder.CardIdRange = new Range(filterBuilder.CardIdRange.Start, new Index(parsed));

            }
            catch (FormatException)
            {
                // TODO: Убрать это, сделать заливку фона у текстбокса.
                MessageBox.Show("Неправильный формат, ввести можно только числа");
                 return;
            }
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
            form1.UpdateRegistry(filterBuilder.Build(), sortingBuilder.Build());
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
