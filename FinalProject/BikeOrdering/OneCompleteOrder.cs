using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeOrdering
{
    public class OneCompleteOrder
    {
        public int orderNumber, count;
        public string userName, phoneNumber;
        public double price;
        public List<Bike> bikes = new List<Bike>();

        public OneCompleteOrder(int orderNumber, string userName, string phoneNumber, List<Bike> bikes, int count, double price)
        {
            this.orderNumber = orderNumber;
            this.userName = userName;
            this.phoneNumber = phoneNumber;
            this.bikes = bikes;
            this.count = count;
            this.price = price;
        }
    }
}