using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace PIS
{
    public partial class Paginator : UserControl
    {
        /// Принимает номер страницы
        public Action<int> OnPageClick;

        public int CurrentPageNumber { get; private set; }
        public int PageCount { get; private set; }

        public void UpdateData(int currentPageNumber, int pageCount)
        {
            PageCount = pageCount;
            CurrentPageNumber = currentPageNumber;

            pageNumberPanel.Controls.Clear();
            foreach (var item in Utils.Paginator.Paginate(currentPageNumber, PageCount))
            {
                switch (item.Type)
                {
                    case Utils.TaggedUnionType.Dots:
                        var pageDots = new PageDots();
                        pageNumberPanel.Controls.Add(pageDots);
                        break;
                    case Utils.TaggedUnionType.Page:
                        var pageValue = item.GetPageValue();
                        var pageNumber = new PageNumber()
                        {
                            Number = pageValue.PageNumber,
                            Selected = pageValue.PageNumber == CurrentPageNumber,
                            OnPageClick = (number) => {
                                if(OnPageClick != null)
                                {
                                    OnPageClick(number);
                                }
                                UpdateData(number, PageCount);
                            }
                        };
                        pageNumberPanel.Controls.Add(pageNumber);
                        break;
                }
            }
        }

        public Paginator()
        {
            InitializeComponent();
        }
    }
}
