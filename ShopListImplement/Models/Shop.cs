using Contracts.BindingModels;
using Contracts.ViewModels;
using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopListImplement.Models
{
    internal class Shop : IShop
    {
        public int Id { get; private set; }
        public string ShopName { get; private set; } = string.Empty;

        public string Author { get; private set; } = string.Empty;

        public DateTime DateOpen { get; private set; }
        public static Shop? Create(ShopBindingModel? model)
        {
            if (model == null)
            {
                return null;
            }
            return new Shop()
            {
                Id = model.Id,
                ShopName = model.ShopName,
                Author = model.Author,
                DateOpen = model.DateOpen
            };
        }

        public void Update(ShopBindingModel? model)
        {
            if (model == null)
            {
                return;
            }
            
            ShopName = ShopName;
            Author = Author;
            DateOpen = DateOpen;
        }

        public ShopViewMode GetViewModel => new()
        {
            Id = Id,
            ShopName = ShopName,
            Author = Author,
            DateOpen = DateOpen,
        };


    }
}
