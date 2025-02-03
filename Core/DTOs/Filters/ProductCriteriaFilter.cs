using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNFarm.Core.DTOs.Filters
{
    public class ProductCriteriaFilter: FilterCriteria
    {
        private int _minPrice { get; set; } = 0;
        public string Keyword { get; set; } = "";
        public int MinPrice {
            get => _minPrice;
            set => _minPrice = Math.Max(value, 0);
        }
        public int? MaxPrice { get; set; } = null;
        public List<int> Rate { get; set; } = new List<int>();
        public List<int> Category { get; set; } = new List<int>();

    }
}
