﻿namespace Example01
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.productComboBox1 = new StoreLibrary.Components.ProductComboBox();
            this.SuspendLayout();
            // 
            // productComboBox1
            // 
            this.productComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.productComboBox1.DropDownHeight = 30;
            this.productComboBox1.FormattingEnabled = true;
            this.productComboBox1.IntegralHeight = false;
            this.productComboBox1.Location = new System.Drawing.Point(58, 62);
            this.productComboBox1.Name = "productComboBox1";
            this.productComboBox1.Size = new System.Drawing.Size(121, 30);
            this.productComboBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 395);
            this.Controls.Add(this.productComboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private StoreLibrary.Components.ProductComboBox productComboBox1;



    }
}

