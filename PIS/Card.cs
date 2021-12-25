using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ClientApi;

namespace PIS
{
    public partial class Card : UserControl
    {
        public Instance Instance { get; set; }

        CardContent cardContent;
        public CardContent CardContent
        {
            get
            {
                return cardContent;
            }
            set
            {
                if (value == null)
                    return;

                cardContent = value;
                cardIdValue.Text = value.CardId.ToString();
            }
        }

        public Action Return;
        EditableCard? editableCard = null;

        public Card()
        {
            InitializeComponent();
        }

        private void statusEditButton_Click(object sender, EventArgs e)
        {
            editableCard = Instance.EditCard(CardContent);

            statusBox1.CurrentStatus = editableCard.CurrentCardStage;
            statusBox1.IsLeftButtonEnabled = editableCard.IsCardSentToPreviousStage;
            statusBox1.IsRightButtonEnabled = editableCard.IsCardSentToNextStage;

            statusBox1.Editable = true;

            statusEditButton.Enabled = false;
            statusSaveButton.Enabled = true;

        }

        private void statusSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                editableCard.Save();
            }
            catch (InvalidConcurrentSaveException)
            {
                MessageBox.Show("Карточку невозможно сохранить, т.к. другой пользователь сохранил ее раньше вас.");
                return;
            }
            catch (ConnectionException)
            {
                MessageBox.Show("Карточку невозможно сохранить, т.к. возникли проблемы с интернет соединением.");
                return;
            }

            editableCard = null;
            statusSaveButton.Enabled = false;
            statusEditButton.Enabled = true;
        }







        private void editButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = false;
            saveButton.Visible = false;
            readButton.Visible = true;

            statusBox.ReadOnly = !statusBox.ReadOnly;
            areaReadBox.Visible = !areaReadBox.Visible;
            areaEditBox.Visible = !areaEditBox.Visible;
            catchDatePicker.Enabled = !catchDatePicker.Enabled;
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            saveButton.Visible = false;
            readButton.Visible = false;
            editButton.Visible = true;

            statusBox.ReadOnly = !statusBox.ReadOnly;
            areaReadBox.Visible = !areaReadBox.Visible;
            areaEditBox.Visible = !areaEditBox.Visible;
            catchDatePicker.Enabled = !catchDatePicker.Enabled;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveButton.Visible = false;
            readButton.Visible = false;
            editButton.Visible = true;

            statusBox.ReadOnly = !statusBox.ReadOnly;
            areaReadBox.Visible = !areaReadBox.Visible;
            areaEditBox.Visible = !areaEditBox.Visible;
            catchDatePicker.Enabled = !catchDatePicker.Enabled;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Excel файлы (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                }
            }
        }


        private void Card_Load(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            saveButton.Enabled = false;
            statusBox1.Editable = false;

            // Инициировать виджет отображения статуса
            statusBox1.CurrentStatus = CardContent.CurrentStatus;
            statusBox1.IsLeftButtonEnabled = statusBox1.IsRightButtonEnabled = false;
            statusBox1.LeftButtonClick = () =>
            {
                if (!editableCard.IsCardSentToPreviousStage)
                    return;

                editableCard.SendCardToPreviousStage();
                statusBox1.CurrentStatus = editableCard.CurrentCardStage;
                statusBox1.IsLeftButtonEnabled = editableCard.IsCardSentToPreviousStage;
                statusBox1.IsRightButtonEnabled = editableCard.IsCardSentToNextStage;
            };
            statusBox1.RightButtonClick = () =>
            {
                if (!editableCard.IsCardSentToNextStage)
                    return;

                editableCard.SendCardToNextStage();
                statusBox1.CurrentStatus = editableCard.CurrentCardStage;
                statusBox1.IsLeftButtonEnabled = editableCard.IsCardSentToPreviousStage;
                statusBox1.IsRightButtonEnabled = editableCard.IsCardSentToNextStage;
            };
        }
    }
}
