using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autorisation.Login = () =>
            {
                autorisation.Visible = false;
                menuPanel.Visible = true;
                cardPanel.Visible = true;
            };

            card.Return = () =>
            {
                card.Visible = false;
                menuPanel.Visible = true;
            };

            var с1 = new CardPreview()
            {
                Status = "123"
            };
            с1.Click += cardPreview_Click;
            cardPanel.Controls.Add(с1);


            var с2 = new CardPreview();
            с2.Click += cardPreview_Click;
            cardPanel.Controls.Add(с2);


        }


        private void cardPreview_Click(object sender, EventArgs e)
        {
            var cardPreview = (CardPreview)sender;
            card.Status = cardPreview.Status;
            card.Area = cardPreview.Area;
            /* ... */

            menuPanel.Visible = false;
            card.Visible = true;
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            profilePanel.Visible = !profilePanel.Visible;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filterPanel.Visible = !filterPanel.Visible;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            cardPanel.Visible = false;
            profilePanel.Visible = false;
            autorisation.Visible = true;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Word файлы (*.docx)|*.docx|Все файлы (*.*)|*.*";
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
