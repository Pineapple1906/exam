using Contracts.BindingModels;
using DataModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopListImplement.Models
{
    internal class Product : IProduct
    {
        public int Id => throw new NotImplementedException();
        public string ProductName => throw new NotImplementedException();

        public double ProductCost => throw new NotImplementedException();

        public DateTime ProductDate => throw new NotImplementedException();

        public string ProductMaker => throw new NotImplementedException();

        public int ShopId => throw new NotImplementedException();
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
                ProductCost = model.ProductCost
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
        }

    }
}
