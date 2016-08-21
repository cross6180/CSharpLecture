using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeOrdering
{
    public interface IModel
    {
        void Register(IView v);

        void RemoveView(IView v);

        void NotifyViews();
    }
}
