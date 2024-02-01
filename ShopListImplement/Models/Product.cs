using Contracts.BindingModels;
using Contracts.ViewModels;
using DataModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShopListImplement.Models
{
    internal class Product : IProduct
    {
        public int Id { get; private set; }
        public string ProductName { get; private set; } = string.Empty;

        public double ProductCost { get; private set; }

        public DateTime ProductDate { get; private set; }

        public string ProductMaker { get; private set; } = string.Empty;

        public int ShopId {get; private set; }
        public static Product? Create(ProductBindingModel? model)
        {
            if (model == null)
            {
                return null;
            }
            return new Product()
            {
                Id = model.Id,
                ProductName = model.ProductName,
                ProductCost = model.ProductCost,
                ProductDate = model.ProductDate,
                ProductMaker = model.ProductMaker,
                ShopId = model.ShopId
            };
        }

        public void Update(ProductBindingModel? model)
        {
            if (model == null)
            {
                return;
            }
            
            ProductName = model.ProductName;
            ProductCost = model.ProductCost;
            ProductDate = model.ProductDate;
            ProductMaker = model.ProductMaker;
            ShopId = model.ShopId;
        }

        public ProductViewModel GetViewModel => new()
        {
            Id = Id,
            ProductName = ProductName,
            ProductCost = ProductCost,
            ProductDate = ProductDate,
            ProductMaker = ProductMaker,
            ShopId = ShopId,
        };

    }
}
