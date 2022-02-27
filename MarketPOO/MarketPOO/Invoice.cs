namespace MarketPOO
{
    public class Invoice : IPay
    {
        private Product _products;
        public Invoice()
        {
            
        }
        public Product AddProduct(Product product)
        {
            
            _products=product;
            return _products;
        }
        public decimal ValueToPay()
        {
            List < Product > Products = new List < Product >();
            decimal total = 0;

            foreach (Product Product in Products)
            {
                total += Product.ValueToPay();
            }
            return total;
        }
        public override string ToString()
        {
            return $" RECEIPT\n" +
                $"------------------------------------------------\n" +
                $"\n\tProducts...:{$"{_products}",15}" +
                $"\n\tTOTAL:......:{$"{ValueToPay():C2}",15}";
        }



    }
}
