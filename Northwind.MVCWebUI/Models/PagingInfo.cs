using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.MVCWebUI.Models
{
    public class PagingInfo
    {
        public int ItemsPageSize { get; set; }
        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int CurrentCategory { get; set; }
    }
}