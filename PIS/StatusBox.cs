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
    public partial class StatusBox : UserControl
    {
        public Action? LeftButtonClick;
        public Action? RightButtonClick;

        Status? currentStatus;
        public Status? CurrentStatus
        {
            get
            {
                return currentStatus;
            }
            set
            {
                currentStatus = value;

                if (!value.HasValue)
                {
                    statusTextBox.Text = "";
                    return;
                }

                statusTextBox.Text = Form1.ConvertStatusToString(value.Value);
            }
        }

        public bool Editable {
            get
            {
                return leftLabel.Visible || rightLabel.Visible;
            }
            set
            {
                leftLabel.Visible = value;
                rightLabel.Visible = value;
            }
        }

        public bool IsLeftButtonEnabled
        {
            get
            {
                return leftLabel.ForeColor != SystemColors.ControlLight;
            }
            set
            {
                leftLabel.ForeColor = value ? SystemColors.ControlText : SystemColors.ControlLight;
            }
        }

        public bool IsRightButtonEnabled
        {
            get
            {
                return rightLabel.ForeColor != SystemColors.ControlLight;
            }
            set
            {
                rightLabel.ForeColor = value ? SystemColors.ControlText : SystemColors.ControlLight;
            }
        }

        public StatusBox()
        {
            InitializeComponent();
        }

        private void leftLabel_Click(object sender, EventArgs e)
        {
            if (!IsLeftButtonEnabled || LeftButtonClick == null)
                return;

            LeftButtonClick();
        }

        private void rightLabel_Click(object sender, EventArgs e)
        {
            if (!IsRightButtonEnabled || RightButtonClick == null)
                return;

            RightButtonClick();
        }
    }
}
