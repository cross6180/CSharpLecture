using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeOrdering
{
    public partial class BikeOrderingForm : Form, IView
    {
        private UserController controller;
        private BikeOrder order;

        public BikeOrderingForm()
        {
            InitializeComponent();
        }

        public BikeOrderingForm(BikeOrder order, UserController controller)
        {
            InitializeComponent();
            this.order = order;
            this.controller = controller;
            this.order.Register(this);
            comboBoxColor.DataSource = Enum.GetValues(typeof(Bike.BikeColor));
            comboBoxType.DataSource = Enum.GetValues(typeof(Bike.BikeType));
            comboBoxBasketColor.DataSource = Enum.GetValues(typeof(Bike.BasketColor));
            comboBoxLock.DataSource = Enum.GetValues(typeof(Bike.LockType));
            comboBoxCount.DataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            listBoxOrdering.DataSource = order.BikeList;
        }

        public void UpdateView()
        {
            listBoxOrdering.DataSource = null;
            listBoxOrdering.DataSource = order.BikeList;
            textBoxUserName.Text = order.UserName;
            textBoxPhoneNumber.Text = order.PhoneNumber;
            comboBoxColor.SelectedIndex = order.BikeColor;
            comboBoxType.SelectedIndex = order.BikeType;
            comboBoxBasketColor.SelectedIndex = order.BasketColor;
            comboBoxLock.SelectedIndex = order.Lock;
            comboBoxCount.SelectedItem = order.Count;
            labelPrice.Text = "總價: " + order.Price.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            controller.UserName = textBoxUserName.Text;
            controller.PhoneNumber = textBoxPhoneNumber.Text;
            controller.BikeColor = comboBoxColor.SelectedIndex;
            controller.BikeType = comboBoxType.SelectedIndex;
            controller.BasketColor = comboBoxBasketColor.SelectedIndex;
            controller.Lock = comboBoxLock.SelectedIndex;
            controller.Count = (int)comboBoxCount.SelectedItem;
            controller.Add();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxOrdering.SelectedItem != null)
                controller.Delete(listBoxOrdering.SelectedIndex);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text) || string.IsNullOrEmpty(textBoxPhoneNumber.Text))
            {
                textBoxUserName.Text = "aaa";
            }
            else
                controller.Save();
        }
    }
}