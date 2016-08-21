using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeOrdering
{
    public class OrderManagement : IModel, IOrderManagement
    {
        private static OrderManagement orderManagement = new OrderManagement();
        private static readonly object syncRoot = new object();
        private List<IView> views = new List<IView>();
        private List<OneCompleteOrder> orders = new List<OneCompleteOrder>();

        private OrderManagement()
        {
        }

        public static OrderManagement GetOrderManagement()
        {
            return orderManagement;
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

        public List<OneCompleteOrder> Orders
        {
            get
            {
                return this.orders;
            }
        }

        public void AddOrder(OneCompleteOrder order)
        {
            this.orders.Add(order);
            NotifyViews();
        }
    }
}