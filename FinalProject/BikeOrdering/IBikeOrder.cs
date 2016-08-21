using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeOrdering
{
    public interface IBikeOrder
    {
        int OrderNumber { get; }

        string UserName { get; set; }

        string PhoneNumber { get; set; }

        int BikeColor { get; set; }

        int BikeType { get; set; }

        int BasketColor { get; set; }

        int Lock { get; set; }

        int Count { get; set; }

        double Price { get; set; }

        List<Bike> BikeList { get; }

        Image BikeImage { get; set; }

        void Add();

        void Delete(int index);

        void Save();
    }
}