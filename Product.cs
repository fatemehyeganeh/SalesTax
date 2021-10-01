namespace SalesTax_WinForm
{
    abstract class Product
    {
        string _Name;
        double _Price;
        string _Import;
        int _Quantity;
        string _Typ;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        public string Import
        {
            get { return _Import; }
            set { _Import = value; }
        }
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        public string Typ
        {
            get { return _Typ; }
            set { _Typ = value; }
        }
        public Product() { }
        public abstract string GetOrder();
        public abstract double Totaltax();
        public abstract double Total();
    }
}
