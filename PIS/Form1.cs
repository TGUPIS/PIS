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
        Instance instance;

        public Form1()
        {
            InitializeComponent();
        }


        public void UpdateRegistry(Filter? filter, Sorting? sorting)
        {
            var currentFilter = filter == null ? new FilterBuilder().Build() : filter;
            var currentSorting = sorting == null ? new SortingBuilder().Build() : sorting;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterPanel1.form1 = this;

            instance = new ClientApi.Instance();

            /*
            var filter = new ClientApi.FilterBuilder().Build();
            var sorting = new ClientApi.SortingBuilder().Build();
            var registry = instance.GetRegistry(filter, sorting);

            foreach(var cardCover in registry.First())
            {

            }
            */

            card.Instance = instance;

            autorisation.Login = () =>
            {
                autorisation.Visible = false;
                menuPanel.Visible = true;
                cardPanel.Visible = true;
                filterPanel1.Visible = true;
            };

            card.Return = () =>
            {
                card.Visible = false;
                filterPanel1.Visible = true;
                menuPanel.Visible = true;
            };



            var с1 = new CardPreview()
            {
                CardCover = new CardCover(instance, 123, Status.AgreedByCatchingOrganization, new DateTime(2021, 8, 5),
                "Тюмень", new DateTime(2021, 9, 4), true, true)
            };
            с1.Click += cardPreview_Click;
            cardPanel.Controls.Add(с1);


            var с2 = new CardPreview()
            {
                CardCover = new CardCover(instance, 234, Status.AgreedByOmsu, new DateTime(2021, 9, 15),
                "Тюмень", new DateTime(2021, 10, 6), false, true)
            };
            с2.Click += cardPreview_Click;
            cardPanel.Controls.Add(с2);

            var с3 = new CardPreview()
            {
                CardCover = new CardCover(instance, 345, Status.SubmittedForRevision, new DateTime(2021, 10, 24),
                "Тюмень", new DateTime(2021, 11, 8), true, false)
            };
            с3.Click += cardPreview_Click;
            cardPanel.Controls.Add(с3);

            var с4 = new CardPreview()
            {
                CardCover = new CardCover(instance, 456, Status.ApprovedByOmsu, new DateTime(2021, 11, 30),
                "Тюмень", new DateTime(2021, 12, 10), false, false)
            };
            с4.Click += cardPreview_Click;
            cardPanel.Controls.Add(с4);



        }


        private void cardPreview_Click(object sender, EventArgs e)
        {
            var cardPreview = (CardPreview)sender;
            card.CardContent = instance.OpenCard(cardPreview.CardCover);

            filterPanel1.Visible = false;
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
