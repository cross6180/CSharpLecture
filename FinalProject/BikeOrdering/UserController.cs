using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeOrdering
{
    public class UserController : IUserController
    {
        public BikeOrder bikeOrder;
        public IView view;

        public UserController(BikeOrder order)
        {
            this.bikeOrder = order;
            this.view = new BikeOrderingForm(order, this);
        }

        public int OrderNumber
        {
            get { return bikeOrder.OrderNumber; }
        }

        public string UserName
        {
            get
            {
                return bikeOrder.UserName;
            }
            set
            {
                bikeOrder.UserName = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return bikeOrder.PhoneNumber;
            }
            set
            {
                bikeOrder.PhoneNumber = value;
            }
        }

        public int BikeColor
        {
            get
            {
                return bikeOrder.BikeColor;
            }
            set
            {
                bikeOrder.BikeColor = value;
            }
        }

        public int BikeType
        {
            get
            {
                return bikeOrder.BikeType;
            }
            set
            {
                bikeOrder.BikeType = value;
            }
        }

        public int BasketColor
        {
            get
            {
                return bikeOrder.BasketColor;
            }
            set
            {
                bikeOrder.BasketColor = value;
            }
        }

        public int Lock
        {
            get
            {
                return bikeOrder.Lock;
            }
            set
            {
                bikeOrder.Lock = value;
            }
        }

        public int Count
        {
            get
            {
                return bikeOrder.Count;
            }
            set
            {
                bikeOrder.Count = value;
            }
        }

        public double Price
        {
            get
            {
                return bikeOrder.Price;
            }
            set
            {
                bikeOrder.Price = value;
            }
        }

        public List<Bike> BikeList
        {
            get
            {
                return bikeOrder.BikeList;
            }
        }

        public System.Drawing.Image BikeImage
        {
            get
            {
                return bikeOrder.BikeImage;
            }
            set
            {
                bikeOrder.BikeImage = value;
            }
        }

        public void Add()
        {
            bikeOrder.Add();
        }

        public void Delete(int index)
        {
            bikeOrder.Delete(index);
        }

        public void Save()
        {
            bikeOrder.Save();
        }
    }
}