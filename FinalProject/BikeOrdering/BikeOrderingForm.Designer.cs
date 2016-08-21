namespace BikeOrdering
{
    partial class BikeOrderingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BikeOrderingForm));
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.listBoxOrdering = new System.Windows.Forms.ListBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelBasketColor = new System.Windows.Forms.Label();
            this.comboBoxBasketColor = new System.Windows.Forms.ComboBox();
            this.labelLockType = new System.Windows.Forms.Label();
            this.comboBoxLock = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pictureBoxBike = new System.Windows.Forms.PictureBox();
            this.comboBoxCount = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBike)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(126, 34);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(186, 29);
            this.textBoxUserName.TabIndex = 0;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(126, 99);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(186, 29);
            this.textBoxPhoneNumber.TabIndex = 1;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(32, 39);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(44, 18);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "姓名";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(32, 102);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(44, 18);
            this.labelPhoneNumber.TabIndex = 3;
            this.labelPhoneNumber.Text = "電話";
            // 
            // listBoxOrdering
            // 
            this.listBoxOrdering.FormattingEnabled = true;
            this.listBoxOrdering.ItemHeight = 18;
            this.listBoxOrdering.Location = new System.Drawing.Point(351, 276);
            this.listBoxOrdering.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxOrdering.Name = "listBoxOrdering";
            this.listBoxOrdering.Size = new System.Drawing.Size(660, 256);
            this.listBoxOrdering.TabIndex = 4;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(126, 164);
            this.comboBoxColor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(186, 26);
            this.comboBoxColor.TabIndex = 5;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(126, 225);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(186, 26);
            this.comboBoxType.TabIndex = 6;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(32, 165);
            this.labelColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(80, 18);
            this.labelColor.TabIndex = 7;
            this.labelColor.Text = "車身顏色";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(32, 228);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(67, 18);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "橫/斜桿";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(34, 549);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 34);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "加入";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(186, 549);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 34);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "刪除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(899, 549);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 34);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "送出訂單";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(32, 417);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(44, 18);
            this.labelCount.TabIndex = 14;
            this.labelCount.Text = "數量";
            // 
            // labelBasketColor
            // 
            this.labelBasketColor.AutoSize = true;
            this.labelBasketColor.Location = new System.Drawing.Point(32, 291);
            this.labelBasketColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBasketColor.Name = "labelBasketColor";
            this.labelBasketColor.Size = new System.Drawing.Size(80, 18);
            this.labelBasketColor.TabIndex = 16;
            this.labelBasketColor.Text = "籃子顏色";
            // 
            // comboBoxBasketColor
            // 
            this.comboBoxBasketColor.FormattingEnabled = true;
            this.comboBoxBasketColor.Location = new System.Drawing.Point(126, 286);
            this.comboBoxBasketColor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBasketColor.Name = "comboBoxBasketColor";
            this.comboBoxBasketColor.Size = new System.Drawing.Size(186, 26);
            this.comboBoxBasketColor.TabIndex = 15;
            // 
            // labelLockType
            // 
            this.labelLockType.AutoSize = true;
            this.labelLockType.Location = new System.Drawing.Point(32, 354);
            this.labelLockType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLockType.Name = "labelLockType";
            this.labelLockType.Size = new System.Drawing.Size(80, 18);
            this.labelLockType.TabIndex = 18;
            this.labelLockType.Text = "鎖的種類";
            // 
            // comboBoxLock
            // 
            this.comboBoxLock.FormattingEnabled = true;
            this.comboBoxLock.Location = new System.Drawing.Point(126, 350);
            this.comboBoxLock.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLock.Name = "comboBoxLock";
            this.comboBoxLock.Size = new System.Drawing.Size(186, 26);
            this.comboBoxLock.TabIndex = 17;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(32, 480);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 18);
            this.labelPrice.TabIndex = 19;
            this.labelPrice.Text = "價錢";
            // 
            // pictureBoxBike
            // 
            this.pictureBoxBike.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBike.Image")));
            this.pictureBoxBike.Location = new System.Drawing.Point(351, 34);
            this.pictureBoxBike.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBike.Name = "pictureBoxBike";
            this.pictureBoxBike.Size = new System.Drawing.Size(660, 220);
            this.pictureBoxBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBike.TabIndex = 20;
            this.pictureBoxBike.TabStop = false;
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxCount.Location = new System.Drawing.Point(126, 412);
            this.comboBoxCount.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(186, 26);
            this.comboBoxCount.TabIndex = 21;
            // 
            // BikeOrderingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 615);
            this.Controls.Add(this.comboBoxCount);
            this.Controls.Add(this.pictureBoxBike);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelLockType);
            this.Controls.Add(this.comboBoxLock);
            this.Controls.Add(this.labelBasketColor);
            this.Controls.Add(this.comboBoxBasketColor);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.listBoxOrdering);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxUserName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BikeOrderingForm";
            this.Text = "BikeOrdering";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.ListBox listBoxOrdering;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelBasketColor;
        private System.Windows.Forms.ComboBox comboBoxBasketColor;
        private System.Windows.Forms.Label labelLockType;
        private System.Windows.Forms.ComboBox comboBoxLock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.PictureBox pictureBoxBike;
        private System.Windows.Forms.ComboBox comboBoxCount;
    }
}

