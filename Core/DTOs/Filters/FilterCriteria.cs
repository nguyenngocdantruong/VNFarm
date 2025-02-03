using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNFarm.Core.DTOs.Filters
{
    public abstract class FilterCriteria : IFilterCriteria
    {
        private int _page { get; set; } = 1;
        private int _pageSize { get; set; } = 10;
        private string _sortBy { get; set; } = "date";
        private string _sortOrder { get; set; } = "desc";
        public int Page { get => _page; set => _page = Math.Clamp(value, 1, 10000); }
        public int PageSize { get => _pageSize; set => _pageSize = Math.Clamp(value, 1, 20); }
        public string SortBy { get => _sortBy; set => _sortBy = value; }
        public string SortOrder { get => _sortOrder; set => _sortOrder = value; }
    }
}
