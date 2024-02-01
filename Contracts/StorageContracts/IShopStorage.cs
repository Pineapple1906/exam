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
    public interface IShopStorage
    {
        List<ShopViewMode> GetFullList();
        List<ShopViewMode> GetFilteredList(ShopSearchModels model);
        ShopViewMode? GetElement(ShopSearchModels model);
        ShopViewMode? Insert(ShopBindingModel model);
        ShopViewMode? Update(ShopBindingModel model);
        ShopViewMode? Delete(ShopBindingModel model);
    }
}
