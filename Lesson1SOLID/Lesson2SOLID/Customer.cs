namespace Lesson2SOLID
{

    // Violation of 'O' in SOLID. Class should be open for extensions but closed for
    // MODIFICATIONS...now say if we have additional CustType....we would need to add another
    // if condition and therefore the customer class will have been MODIFIED!!
    class Customer
    {
        private int _CustType;

        public int CustType
        {
            get { return _CustType; }
            set { _CustType = value; }
        }

        public double getDiscount(double TotalSales)
        {
            if (_CustType == 1)
            {
                return TotalSales - 100;
            }
            else
            {
                return TotalSales - 50;
            }
        }
    }
}
