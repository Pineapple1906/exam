using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BindingModels
{
    public class ShopBindingModel : IShop
    {
        public string ShopName { get; set; }

        public string Author { get; set; }

        public DateTime DateOpen { get; set; }

        public int Id { get; set; }
    }
}
