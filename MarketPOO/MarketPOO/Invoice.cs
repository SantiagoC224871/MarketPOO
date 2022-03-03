namespace MarketPOO
{
    public class Invoice : IPay
    {
        public Invoice()
        {

        }
        private List<Product> _products = new List<Product>();
        public void AddProduct(Product Product)
        {
            _products.Add(Product);
        }
        public decimal ValueToPay()
        {

            decimal total = 0;

            foreach (Product Product in _products)
            {
                total += Product.ValueToPay();
            }
            return total;
        }
        public override string ToString()
        {
            Console.WriteLine($" RECEIPT\n" +
                $"------------------------------------------------");
            foreach (Product Product in _products)
            {
                Console.WriteLine(Product.ToString());
            }
            return 
                $"\t\t     =============="+
                $"\nTOTAL:{$"\t\t{ValueToPay():C2}",15}";
        }



    }
}
