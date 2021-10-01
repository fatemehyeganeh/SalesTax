using System;
using System.Windows.Forms;

namespace SalesTax_WinForm
{
    public partial class frm_SaleTax : Form
    {
        public frm_SaleTax()
        {
            InitializeComponent();
        }
        int counter = 0;
        double sumtax = 0;
        double sum = 0;
        int maxfactoritems = 100;
        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            counter++;
            Product[] order = new Product[maxfactoritems];
            order[counter] = new Order();
            order[counter].Quantity = int.Parse(ProductQuantity.Value.ToString());
            order[counter].Name = ProductName_cmbBox.Text;
            order[counter].Price = double.Parse(ProductPrice_txtBox.Text);
            order[counter].Import = IsImported_cmbBox.Text;
            order[counter].Typ = IsSpecial_cmbBox.Text;
            Orders_list.Items.Add(order[counter].GetOrder());
            CleanOrderForm();
            sum += order[counter].Total();
            sumtax += order[counter].Totaltax();
            lbl_totaltax.Text = sumtax.ToString();
            lbl_Total.Text = sum.ToString(); ;
        }

        public void CleanOrderForm()
        {
            ProductPrice_txtBox.Text = "0.0";
            ProductQuantity.Value = 1;
            IsImported_cmbBox.Text = "No";
            IsSpecial_cmbBox.Text = "No";
            ProductName_cmbBox.Text = "";


        }

        private void btn_newfactor_Click(object sender, EventArgs e)
        {
            Orders_list.Items.Clear();
            lbl_Total.Text = "";
            lbl_totaltax.Text = "";
            counter = 0;
            sum = 0;
            sumtax = 0;

            CleanOrderForm();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductPrice_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
