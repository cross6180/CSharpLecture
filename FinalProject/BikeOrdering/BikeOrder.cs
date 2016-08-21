using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeOrdering
{
    public class BikeOrder : IModel, IBikeOrder
    {
        private List<IView> views = new List<IView>();
        private int orderNumber, count;
        private double price = 0.0;
        private List<Bike> bikes = new List<Bike>();

        public void InitialBikeOrder()
        {
            UserName = "";
            bikes.Clear();
            PhoneNumber = "";
            BikeColor = 0;
            BikeType = 0;
            BasketColor = 0;
            Lock = 0;
            count = 0;
            price = 0.0;
        }

        public void Register(IView v)
        {
            views.Add(v);
        }

        public void RemoveView(IView v)
        {
            views.Remove(v);
        }

        public void NotifyViews()
        {
            foreach (var v in views)
                v.UpdateView();
        }

        public int OrderNumber
        {
            get
            {
                return this.orderNumber;
            }
        }

        public string UserName
        {
            get;
            set;
        }

        public string PhoneNumber
        {
            get;
            set;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                if (value < 0)
                    this.count = 0;
                else if (value > 10)
                    this.count = 10;
                else
                    this.count = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public List<Bike> BikeList
        {
            get
            {
                return this.bikes;
            }
        }

        public System.Drawing.Image BikeImage
        {
            get;
            set;
        }

        public int BikeColor
        {
            get;
            set;
        }

        public int BikeType
        {
            get;
            set;
        }

        public int BasketColor
        {
            get;
            set;
        }

        public int Lock
        {
            get;
            set;
        }

        public void Add()
        {
            Bike bike = new Bike(this.BikeColor, this.BasketColor, this.Lock, this.BikeType, this.count);
            this.bikes.Add(bike);
            this.price += bike.CountPrice();
            NotifyViews();
        }

        public void Delete(int index)
        {
            this.price -= this.bikes[index].CountPrice();
            this.bikes.RemoveAt(index);
            NotifyViews();
        }

        public void Save()
        {
            orderNumber++;
            OrderManagement.GetOrderManagement().AddOrder(new OneCompleteOrder(this.orderNumber, this.UserName, this.PhoneNumber, this.bikes, this.count, this.price));
            InitialBikeOrder();
            NotifyViews();
        }
    }
}