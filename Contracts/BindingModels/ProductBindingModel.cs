using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BindingModels
{
    public class ProductBindingModel : IProduct
    {
        public string ProductName {get; set;}

        public double ProductCost { get; set; }

        public DateTime ProductDate { get; set; }

        public string ProductMaker { get; set; }

        public int ShopId { get; set; }

        public int Id { get; set; }
    }
}
