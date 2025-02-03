using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNFarm.Core.DTOs.Filters
{
    public interface IFilterCriteria
    {
        int Page { get; set; }
        int PageSize { get; set; }
        string SortBy { get; set; } 
        string SortOrder { get; set; }
    }
}
