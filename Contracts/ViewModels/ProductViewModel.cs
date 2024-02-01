using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ViewModels
{
    public class ProductViewModel:IProduct
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public double ProductCost { get; set; }
        public DateTime ProductDate { get; set; }
        public string ProductMaker { get; set; } = string.Empty;
        public int ShopId { get; set; }
    }
}
