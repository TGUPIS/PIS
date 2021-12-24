using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIS
{
    public partial class PageNumber : UserControl
    {
        /// Принимает номер страницы
        public Action<int> OnPageClick;

        int pageNumber;
        public int Number
        {
            get
            {
                return pageNumber;
            }
            set
            {
                pageNumber = value;
                pageNumberBox.Text = pageNumber.ToString();
            }
        }

        public bool Selected
        {
            get
            {
                return pageNumberBox.BackColor == Color.FromArgb(200, 222, 186);
            }
            set
            {
                pageNumberBox.BackColor = value ? Color.FromArgb(200, 222, 186) : SystemColors.Control;
            }
        }

        public PageNumber()
        {
            InitializeComponent();
        }

        private void pageNumberBox_Click(object sender, EventArgs e)
        {
            if (OnPageClick == null)
                return;

            OnPageClick(pageNumber);
        }
    }
}
