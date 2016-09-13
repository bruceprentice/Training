using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public interface IBaseRating
    {
         int HasDiscount(IRatingDescriptor descriptor);
         int IsShipmentPriced(IBaseRating rating);
    }
}
