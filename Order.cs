using System;

namespace SalesTax_WinForm
{
    class Order : Product
    {
        public Order() { }
        public Order(int quantity, string name, double price, string import, string typ) { }

        double _TotalPrice;
        double _TotalTax;
        double _TaxRate;
        public double TaxRate
        {
            get { return _TaxRate; }
            set { _TaxRate = value; }
        }
        public double totaltax
        {
            get { return _TotalTax; }
            set { _TotalTax = value; }
        }
        public double totalprice
        {
            get { return _TotalPrice; }
            set { _TotalPrice = value; }
        }
        public override string GetOrder()
        {
            string orderstr;
            orderstr = Quantity.ToString() + " " + Name + " at " + Price.ToString() + " >> " + Rounding(Price2() + Taxval()).ToString();
            return orderstr;
        }
        public override double Totaltax()
        {
            totaltax += Taxval();
            return Rounding(totaltax);
        }
        public override double Total()
        {
            totalprice += Price2() + Taxval();
            return Rounding(totalprice);
        }
        public double Rounding(double n)
        {
            double ROUND_OFF = 0.05;
            double roundednum = (int)(n / ROUND_OFF + 0.5) * 0.05;
            roundednum = Math.Round(roundednum, 2);
            return roundednum;
        }
        public double taxRate()
        {
            if (Typ == "Yes") TaxRate = 0.0; else TaxRate = 0.1;
            if (Import == "Yes") TaxRate += 0.05;
            return TaxRate;
        }
        public double Price2()
        {
            double price2 = Price * Quantity;
            return price2;
        }
        public double Taxval()
        {
            double taxval = Price2() * taxRate();
            return taxval;
        }
    }
}
