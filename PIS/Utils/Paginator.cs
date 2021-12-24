using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PIS.Utils
{
    public static class Paginator
    {
        /// <summary>
        /// Бросает `ArgumentException`, если аргументы не соответствуют своим ограничениям
        /// </summary>
        /// <param name="currentPageNumber">1+</param>
        /// <param name="pageCount">0+</param>
        /// <returns></returns>
        public static PaginatorItem[] Paginate(int currentPageNumber, int pageCount)
        {
            if (currentPageNumber < 1 || pageCount < 0)
                throw new ArgumentException();

            var delta = 0;
            if (pageCount <= 7)
            {
                delta = 7;
            }
            else
            {
                delta = currentPageNumber > 4 && currentPageNumber < pageCount - 3 ? 2 : 4;
            }

            var rangeStart = currentPageNumber - delta / 2;
            var rangeEnd = currentPageNumber + delta / 2;

            if (rangeStart - 1 == 1 || rangeEnd + 1 == pageCount)
            {
                rangeStart += 1;
                rangeEnd += 1;
            }

            var pages = currentPageNumber > delta
                ? GetRange(Math.Min(rangeStart, pageCount - delta), Math.Min(rangeEnd, pageCount))
                : GetRange(1, Math.Min(pageCount, delta + 1));

            if (pages.Length > 0 && pages[0].GetPageValue().PageNumber != 1)
            {
                var beginPages = pages.Length + 1 != pageCount
                    ? new PaginatorItem[]
                    {
                        new PaginatorItem(TaggedUnionType.Page, new Page(1)),
                        new PaginatorItem(TaggedUnionType.Dots, null)
                    }
                    : new PaginatorItem[]
                    {
                        new PaginatorItem(TaggedUnionType.Page, new Page(1))
                    };
                pages = beginPages.Concat(pages).ToArray();
            }

            if (pages.Length > 0 && pages[pages.Length - 1].GetPageValue().PageNumber < pageCount)
            {
                var endPages = pages.Length + 1 != pageCount
                    ? new PaginatorItem[] {
                        new PaginatorItem(TaggedUnionType.Dots, null),
                        new PaginatorItem(TaggedUnionType.Page, new Page(pageCount))
                    }
                    : new PaginatorItem[] { new PaginatorItem(TaggedUnionType.Page, new Page(pageCount)) };
                pages = pages.Concat(endPages).ToArray();
            }

            return pages;
        }

        static PaginatorItem[] GetRange(int start, int end)
        {
            return Enumerable.Range(0, end - start + 1)
                .Select((x, i) => new PaginatorItem(TaggedUnionType.Page, new Page(i + start)))
                .ToArray();
        }
    }

    public enum TaggedUnionType
    {
        Page,
        Dots
    }

    public class PaginatorItem
    {
        object? value;
        public TaggedUnionType Type { get; private set; }

        /// Бросает `ArgumentException`, если `type == Page && value == null`
        public PaginatorItem(TaggedUnionType type, object? value)
        {
            if (type == TaggedUnionType.Page && value == null)
                throw new ArgumentException();

            Type = type;
            this.value = value;
        }

        /// Бросает `InvalidCastException`, если `type != Page`
        public Page GetPageValue()
        {
            if (Type != TaggedUnionType.Page)
                throw new InvalidCastException();

            return (Page)value;
        }
    }

    public class Page
    {
        public int PageNumber { get; private set; }
        internal Page(int pageNumber)
        {
            PageNumber = pageNumber;
        }
    }
}
