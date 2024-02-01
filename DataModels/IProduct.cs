using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public interface IProduct:IID
    {
        string ProductName { get; }
        double ProductCost { get; }
        DateTime ProductDate { get; }
        string ProductMaker { get; }
        int ShopId { get; }
     
    }
}
