using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIS
{
    public partial class CardPreview : UserControl
    {
        public bool Selected
        {
            get
            {
                return BackColor != SystemColors.Control;
            }
            private set
            {
                BackColor = value ? SystemColors.GradientActiveCaption : SystemColors.Control;
            }
        }

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
                return areaBox.Text;
            }
            set
            {
                areaBox.Text = value;
            }
        }


        public CardPreview()
        {
            InitializeComponent();
        }


        protected override void OnClick(EventArgs e)
        {
            if (Form.ModifierKeys == Keys.Control)
            {
                Selected = !Selected;
            }
            else
            {
                base.OnClick(e);
            }
        }


        private void CardPreview_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
