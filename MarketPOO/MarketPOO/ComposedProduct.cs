namespace MarketPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public List<Product> Products { get; set; }
        public override decimal ValueToPay()
        {
            decimal total = 0;
            foreach (Product Product in Products)
            {
                total += Product.ValueToPay();
            }
            return total-(total*(decimal)0.12);
        }
        public override string ToString()
        {
            List<String> composedproducts = new List<String>();

            foreach (Product Product in Products)
            {
                composedproducts.Add(Product.Description);
            }
            return $"   {Id} {Description}" +
            $"\n\tProducts...: {$"{String.Join(",", composedproducts)}",15}" +
            $"\n\tDiscount...: {$"{Discount:P2}",15}" +
            $"\n\tValue......: {$"{ValueToPay():C2}",15}";
        }
    }
}

