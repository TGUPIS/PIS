using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PIS
{
    public partial class Card : UserControl
    {
        public Action Return;

        public string Status
        {
            get
            {
                return statusBox.Text;
            }
            set
            {
                statusBox.Text = value;
            }
        }

        public string Area
        {
            get
            {
                return areaReadBox.Text;
            }
            set
            {
                areaReadBox.Text = value;
            }
        }


        public Card()
        {
            InitializeComponent();
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
    }
}
