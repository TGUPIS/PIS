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
using ClientApi;

namespace PIS
{
    public partial class Form1 : Form
    {
        public Instance instance;
        public Filter Filter { get; set; }
        public Sorting Sorting { get; set; }

        int currentPageNumber = 1;
        public Form1()
        {
            InitializeComponent();
        }


        public void UpdateCardCovers(int? pageNumber)
        {
            if(!pageNumber.HasValue)
            {
                pageNumber = currentPageNumber;
            } else
            {
                currentPageNumber = pageNumber.Value;
            }

            var registry = instance.GetRegistry(Filter, Sorting);
            filterPanel1.CountOfEditableCardsWithNotifications = registry.CountOfEditableCardsWithNotifications;
            filterPanel1.CountOfEditableCardsWithoutNotifications = registry.CountOfEditableCardsWithoutNotifications;
            filterPanel1.CountOfOtherCards = registry.CountOfOtherCards;

            cardPanel.Controls.Clear();
            foreach (var cardCover in registry[pageNumber.Value])
            {
                var cardPreview = new CardPreview()
                {
                    CardCover = cardCover
                };
                cardPreview.Click += cardPreview_Click;
                cardPanel.Controls.Add(cardPreview);
            }

            paginatorBox.UpdateData(pageNumber.Value, registry.PageCount);
            paginatorBox.Left = (paginatorPanel.Width - paginatorBox.Width) / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            instance = new Instance();

            Filter = new FilterBuilder().Build(instance);
            Sorting = new SortingBuilder().Build(instance);

            filterPanel1.form1 = this;

            UpdateCardCovers(1);

            card.Instance = instance;

            autorisation.Login = () =>
            {
                autorisation.Visible = false;
                menuPanel.Visible = true;
                cardPanel.Visible = true;
                filterPanel1.Visible = true;
                paginatorPanel.Visible = true;
            };

            card.Return = () =>
            {
                UpdateCardCovers(null);

                card.Visible = false;
                filterPanel1.Visible = true;
                paginatorPanel.Visible = true;
                menuPanel.Visible = true;
            };

            paginatorBox.OnPageClick = (pageNumber) =>
            {
                UpdateCardCovers(pageNumber);
            };

        }


        private void cardPreview_Click(object sender, EventArgs e)
        {
            var cardPreview = (CardPreview)sender;
            card.CardContent = instance.OpenCard(cardPreview.CardCover);

            filterPanel1.Visible = false;
            paginatorPanel.Visible = false;
            menuPanel.Visible = false;
            card.Visible = true;
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            profilePanel.Visible = !profilePanel.Visible;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            filterPanel1.Visible = false;
            paginatorPanel.Visible = false;
            menuPanel.Visible = false;
            cardPanel.Visible = false;
            profilePanel.Visible = false;
            autorisation.Visible = true;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {

        }

        public static string ConvertStatusToString(Status status)
        {
            return status switch
            {
                Status.SubmittedForRevision => "Отправлено на доработку",
                Status.Draft => "Черновик",
                Status.AgreementByCatchingOrganization => "Согласование в организации по отлову",
                Status.AgreedByCatchingOrganization => "Согласовано в организации по отлову",
                Status.ApprovedByCatchingOrganization => "Утверждено в организации по отлову",
                Status.AgreedByOmsu => "Согласовано в ОМСУ",
                Status.ApprovedByOmsu => "Утверждено в ОМСУ",
                _ => throw new Exception()
            };
        }
    }
}
