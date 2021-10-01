
namespace SalesTax_WinForm
{
    partial class frm_SaleTax
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductPrice_txtBox = new System.Windows.Forms.TextBox();
            this.ProductName_cmbBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IsImported_cmbBox = new System.Windows.Forms.ComboBox();
            this.IsSpecial_cmbBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Orders_list = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.ProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.btn_newfactor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_totaltax = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product\'s Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Selected Product\'s Price:";
            // 
            // ProductPrice_txtBox
            // 
            this.ProductPrice_txtBox.Location = new System.Drawing.Point(320, 283);
            this.ProductPrice_txtBox.Name = "ProductPrice_txtBox";
            this.ProductPrice_txtBox.Size = new System.Drawing.Size(260, 31);
            this.ProductPrice_txtBox.TabIndex = 1;
            this.ProductPrice_txtBox.Text = "0.0";
            this.ProductPrice_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductPrice_txtBox_KeyPress);
            // 
            // ProductName_cmbBox
            // 
            this.ProductName_cmbBox.FormattingEnabled = true;
            this.ProductName_cmbBox.Items.AddRange(new object[] {
            "Book",
            "music CD",
            "chocolate bar",
            "imported box of chocolates",
            "bottle of perfume",
            "imported bottle of perfume",
            "packet of headache pills",
            "box of imported chocolates"});
            this.ProductName_cmbBox.Location = new System.Drawing.Point(320, 221);
            this.ProductName_cmbBox.Name = "ProductName_cmbBox";
            this.ProductName_cmbBox.Size = new System.Drawing.Size(260, 33);
            this.ProductName_cmbBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "How many?";
            // 
            // IsImported_cmbBox
            // 
            this.IsImported_cmbBox.FormattingEnabled = true;
            this.IsImported_cmbBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.IsImported_cmbBox.Location = new System.Drawing.Point(320, 395);
            this.IsImported_cmbBox.Name = "IsImported_cmbBox";
            this.IsImported_cmbBox.Size = new System.Drawing.Size(260, 33);
            this.IsImported_cmbBox.TabIndex = 3;
            this.IsImported_cmbBox.Text = "No";
            // 
            // IsSpecial_cmbBox
            // 
            this.IsSpecial_cmbBox.FormattingEnabled = true;
            this.IsSpecial_cmbBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.IsSpecial_cmbBox.Location = new System.Drawing.Point(320, 448);
            this.IsSpecial_cmbBox.Name = "IsSpecial_cmbBox";
            this.IsSpecial_cmbBox.Size = new System.Drawing.Size(260, 33);
            this.IsSpecial_cmbBox.TabIndex = 4;
            this.IsSpecial_cmbBox.Text = "No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Is Imported?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Is Special?";
            // 
            // Orders_list
            // 
            this.Orders_list.FormattingEnabled = true;
            this.Orders_list.ItemHeight = 25;
            this.Orders_list.Location = new System.Drawing.Point(881, 231);
            this.Orders_list.Name = "Orders_list";
            this.Orders_list.Size = new System.Drawing.Size(476, 279);
            this.Orders_list.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(876, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Order List";
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.Location = new System.Drawing.Point(622, 221);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(225, 107);
            this.btn_addOrder.TabIndex = 5;
            this.btn_addOrder.Text = "Add Order";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.Location = new System.Drawing.Point(320, 342);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(120, 31);
            this.ProductQuantity.TabIndex = 2;
            this.ProductQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_newfactor
            // 
            this.btn_newfactor.Location = new System.Drawing.Point(881, 10);
            this.btn_newfactor.Name = "btn_newfactor";
            this.btn_newfactor.Size = new System.Drawing.Size(151, 60);
            this.btn_newfactor.TabIndex = 19;
            this.btn_newfactor.Text = "New Factor";
            this.btn_newfactor.UseVisualStyleBackColor = true;
            this.btn_newfactor.Click += new System.EventHandler(this.btn_newfactor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1083, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 58);
            this.button1.TabIndex = 23;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(716, 647);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Total Tax:";
            // 
            // lbl_totaltax
            // 
            this.lbl_totaltax.AutoSize = true;
            this.lbl_totaltax.Location = new System.Drawing.Point(876, 647);
            this.lbl_totaltax.Name = "lbl_totaltax";
            this.lbl_totaltax.Size = new System.Drawing.Size(0, 25);
            this.lbl_totaltax.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(716, 723);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Total : ";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(876, 723);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(0, 25);
            this.lbl_Total.TabIndex = 26;
            // 
            // frm_SaleTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 1007);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_totaltax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_newfactor);
            this.Controls.Add(this.ProductQuantity);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Orders_list);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IsSpecial_cmbBox);
            this.Controls.Add(this.IsImported_cmbBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductName_cmbBox);
            this.Controls.Add(this.ProductPrice_txtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "frm_SaleTax";
            this.Text = "Sale";
           
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductPrice_txtBox;
        private System.Windows.Forms.ComboBox ProductName_cmbBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox IsImported_cmbBox;
        private System.Windows.Forms.ComboBox IsSpecial_cmbBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox Orders_list;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.NumericUpDown ProductQuantity;
        private System.Windows.Forms.Button btn_newfactor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_totaltax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_Total;
    }
}

