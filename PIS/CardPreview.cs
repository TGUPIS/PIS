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
    public partial class CardPreview : UserControl
    {
        CardCover cardCover;
        public CardCover CardCover {
            get
            {
                return cardCover;
            }
            set
            {
                cardCover = value;
                idLabel.Text = "#" + value.CardId.ToString();
                statusBox.Text = Form1.ConvertStatusToString(value.Status);
                areaBox.Text = value.CatchLocality;

                isCommentedBox.Visible = value.IsCommented;
                isPdfAttachedBox.Visible = value.IsPdfAttached;
                if(value.IsPdfAttached && !value.IsCommented)
                {
                    isPdfAttachedBox.Location = isCommentedBox.Location;
                }

                statusChangeDateBox.Text = value.StatusChangeDate.ToString("dd.MM.yyyy");
                catchDateBox.Text = value.CatchDate.ToString("MM.yyyy");
            }
        }

        public CardPreview()
        {
            InitializeComponent();
        }

        private void CardPreview_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
