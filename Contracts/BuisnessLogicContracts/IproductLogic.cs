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
    internal interface IproductLogic
    {
        List<ProductViewModel>? ReadList(ProductSearchModels? model);
        ProductViewModel? ReadElement(ProductSearchModels? model);
        bool Create(ProductBindingModel model);
        bool Update(ProductBindingModel model);
        bool Delete(ProductBindingModel model);
    }
}
