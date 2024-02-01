using Contracts.BindingModels;
using Contracts.SearchModels;
using Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BuisnessLogicContracts
{
    internal interface IshopLogic
    {
        List<ShopViewMode>? ReadList(ShopSearchModels? model);
        ShopViewMode? ReadElement(ShopSearchModels? model);
        bool Create(ShopBindingModel model);
        bool Update(ShopBindingModel model);
        bool Delete(ShopBindingModel model);
    }
}
