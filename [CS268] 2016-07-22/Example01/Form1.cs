using StoreLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            productComboBox1.Items.Add(new Product()
            {
                Name = "iPhone 6s",
                Price = 28900,
                Category = "手機",
                Status = "熱賣"
            });
            productComboBox1.Items.Add(new Product()
            {
                Name = "iPhone 6s plus",
                Price = 32900,
                Category = "手機",
                Status = "降價"
            });
            productComboBox1.Items.Add(new Product()
            {
                Name = "iPhone 6s SE",
                Price = 15900,
                Category = "手機",
                Status = "綠標"
            });
            productComboBox1.Items.Add(new Product()
            {
                Name = "iPhone 6s aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                Price = 1822222900,
                Category = "手機",
                Status = "綠標"
            });
        }
    }
}