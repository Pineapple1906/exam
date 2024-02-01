using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public interface IShop:IID
    {
        string ShopName { get; }
        string Author { get; }
        DateTime DateOpen { get; }
    }
}
