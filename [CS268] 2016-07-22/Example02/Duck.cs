using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    //抽象類別
    public abstract class Duck
    {
        public string Name { get; set; }
        public IFlyBehavior flybehavior;

        //抽象方法，知道可以飛，但不知道怎麼飛
        public void fly()
        {
            if (flybehavior == null)
                this.flybehavior = new 不會飛();

            flybehavior.Fly();
        }
    }
}