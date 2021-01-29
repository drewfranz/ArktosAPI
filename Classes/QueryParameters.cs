using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArktosAPI.Classes
{
    public class QueryParameters
    {
        const int _MaxPageSize = 100;
        private int _pageSize = 20;

        public int Page { get; set; }
        public int PageSize {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = Math.Min(_MaxPageSize, value);
            }
        }

        public string SortBy { get; set; } = "Id";
        private string _sortOrder = "asc";
        public string SortOrder
        {
            get
            {
                return _sortOrder;
            }
            set
            {
                if (value == "asc" || value == "desc")
                {
                    _sortOrder = value;
                }
            }
        }
    }
}
