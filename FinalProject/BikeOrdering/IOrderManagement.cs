using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeOrdering
{
    public interface IOrderManagement
    {
        List<OneCompleteOrder> Orders { get; }

        void AddOrder(OneCompleteOrder order);
    }
}