namespace CS223_LabSession_4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_sku = new System.Windows.Forms.Label();
            this.lbl_itemName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.txt_Sku = new System.Windows.Forms.TextBox();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(121, 52);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(44, 13);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "Number";
            this.lbl_number.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(302, 52);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(30, 13);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            // 
            // lbl_sku
            // 
            this.lbl_sku.AutoSize = true;
            this.lbl_sku.Location = new System.Drawing.Point(505, 52);
            this.lbl_sku.Name = "lbl_sku";
            this.lbl_sku.Size = new System.Drawing.Size(29, 13);
            this.lbl_sku.TabIndex = 2;
            this.lbl_sku.Text = "SKU";
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.Location = new System.Drawing.Point(64, 128);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(58, 13);
            this.lbl_itemName.TabIndex = 3;
            this.lbl_itemName.Text = "Item Name";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(88, 94);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(100, 20);
            this.txt_Number.TabIndex = 4;
            // 
            // txt_Sku
            // 
            this.txt_Sku.Location = new System.Drawing.Point(466, 94);
            this.txt_Sku.Name = "txt_Sku";
            this.txt_Sku.Size = new System.Drawing.Size(100, 20);
            this.txt_Sku.TabIndex = 6;
            // 
            // txt_itemName
            // 
            this.txt_itemName.Location = new System.Drawing.Point(157, 128);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(507, 20);
            this.txt_itemName.TabIndex = 7;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(157, 157);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 20);
            this.txt_qty.TabIndex = 8;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(334, 158);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 9;
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(76, 160);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(46, 13);
            this.lbl_qty.TabIndex = 10;
            this.lbl_qty.Text = "Quantity";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(275, 161);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(31, 13);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "Price";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(480, 164);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(623, 164);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(243, 94);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 236);
            this.dataGridView1.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AcceptButton = this.btn_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.txt_Sku);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.lbl_itemName);
            this.Controls.Add(this.lbl_sku);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_number);
            this.Name = "Form2";
            this.Text = "FILL IT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_sku;
        private System.Windows.Forms.Label lbl_itemName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.TextBox txt_Sku;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}