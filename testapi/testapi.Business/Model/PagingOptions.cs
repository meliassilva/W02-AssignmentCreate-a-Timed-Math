﻿using Byui.testapi.Business.Enums;

namespace Byui.testapi.Business.Model
{
    public class PagingOptions
    {
        public int PageSize { get; set; }
        public int Page { get; set; }
        public string SortBy { get; set; }
        public SortDirection SortDirection { get; set; }

        internal int RecordsToSkip()
        {
            return (Page - 1) * PageSize;
        }
    }
}
