using DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ViewModels
{
    public class ShopViewMode:IShop
    {
        public int Id { get; set; }
        [DisplayName("Название магазина")]
        public string ShopName { get; set; } = string.Empty;
        [DisplayName("Дата открытия")]
        public DateTime DateOpen { get; set; } = DateTime.Now;
        [DisplayName("Автор")]
        public string Author { get; set; } = string.Empty;
    }
}
