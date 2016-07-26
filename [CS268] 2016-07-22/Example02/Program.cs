using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            duck.fly();
            duck.flybehavior = new 飛毯();
            duck.fly();
        }
    }
}