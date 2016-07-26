using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreLibrary.Components
{
    //internal -> 只開放給這個專案用
    //public   -> 權限全開放
    public class ProductComboBox : ComboBox
    {
        public ProductComboBox()
            : base()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            if (e.Index < 0) return;
            e.DrawBackground();
            if (this.Items[e.Index] is Product) //現在正在畫的這個item是產品的話
            {
                Product product = this.Items[e.Index] as Product;
                //新增字形
                Font font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
                //新增筆刷
                Brush brush = new SolidBrush(product.Color);
                e.Graphics.DrawString(product.ToString(), font, brush, e.Bounds.X, e.Bounds.Y);
            }
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            base.OnMeasureItem(e);

            e.ItemHeight = 30;
            this.DropDownHeight = this.Items.Count * e.ItemHeight + 2;

            Graphics g = this.CreateGraphics();
            this.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
            int maxSize = this.Width;
            if (this.Items[e.Index] is Product)
            {
                Product product = this.Items[e.Index] as Product;
                int size = (int)g.MeasureString(product.ToString(), this.Font).Width;
                if (maxSize < size)
                {
                    maxSize = size + SystemInformation.VerticalScrollBarWidth;
                }
                this.DropDownWidth = maxSize;
                this.Width = maxSize;
            }
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            if (this.SelectedItem is Product)
            {
                Product product = this.SelectedItem as Product;
                this.ForeColor = product.Color;
                //this.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
            }
        }
    }
}