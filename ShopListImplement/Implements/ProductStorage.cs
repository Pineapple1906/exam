using Contracts.BindingModels;
using Contracts.SearchModels;
using Contracts.StorageContracts;
using Contracts.ViewModels;
using ShopListImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopListImplement.Implements
{
    public class ProductStorage : IProductStorage
    {
        private readonly DataListSingleton _source;
        public ProductStorage()
        {
            _source = DataListSingleton.GetInstance();
        }
        public List<ProductViewModel> GetFullList()
        {
            var result = new List<ProductViewModel>();
            foreach (var product in _source.Products)
            {
                result.Add(product.GetViewModel);
            }
            return result;
        }
        public List<ProductViewModel> GetFilteredList(ProductSearchModels model)
        {
            var result = new List<ProductViewModel>();
            if (string.IsNullOrEmpty(model.ProductName))
            {
                return result;
            }
            foreach (var product in _source.Products)
            {
                if (product.ProductName.Contains(model.ProductName))
                {
                    result.Add(product.GetViewModel);
                }
            }
            return result;
        }
        public ProductViewModel? GetElement(ProductSearchModels model)
        {
            if (string.IsNullOrEmpty(model.ProductName) && !model.ID.HasValue)
            {
                return null;
            }
            foreach (var product in _source.Products)
            {
                if ((!string.IsNullOrEmpty(model.ProductName) &&
               product.ProductName == model.ProductName) ||
                (model.ID.HasValue && product.Id == model.ID))
                {
                    return product.GetViewModel;
                }
            }
            return null;
        }
        public ProductViewModel? Insert(ProductBindingModel model)
        {
            model.Id = 1;
            foreach (var product in _source.Products)
            {
                if (model.Id <= product.Id)
                {
                    model.Id = product.Id + 1;
                }
            }
            var newProduct = Product.Create(model);
            if (newProduct == null)
            {
                return null;
            }
            _source.Products.Add(newProduct);
            return newProduct.GetViewModel;
        }
        public ProductViewModel? Update(ProductBindingModel model)
        {
            foreach (var product in _source.Products)
            {
                if (product.Id == model.Id)
                {
                    product.Update(model);
                    return product.GetViewModel;
                }
            }
            return null;
        }
        public ProductViewModel? Delete(ProductBindingModel model)
        {
            for (int i = 0; i < _source.Products.Count; ++i)
            {
                if (_source.Products[i].Id == model.Id)
                {
                    var element = _source.Products[i];
                    _source.Products.RemoveAt(i);
                    return element.GetViewModel;
                }
            }
            return null;
        }
    }
}
