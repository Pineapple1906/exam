using Contracts.BindingModels;
using Contracts.SearchModels;
using Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.StorageContracts
{
    public interface IProductStorage
    {
        List<ProductViewModel> GetFullList();
        List<ProductViewModel> GetFilteredList(ProductSearchModels model);
        ProductViewModel? GetElement(ProductSearchModels model);
        ProductViewModel? Insert(ProductBindingModel model);
        ProductViewModel? Update(ProductBindingModel model);
        ProductViewModel? Delete(ProductBindingModel model);

    }
}
