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
            return $"   {Id} {Description}" +
                $"\n\tProducts...:{$" {Products[0].Description}, {Products[1].Description}, {Products[2].Description}, {Products[3].Description}",15}" +
                $"\n\tDiscount...:{$"{Discount:P2}",15}" +
                $"\n\tValue......:{$"{ValueToPay():C2}",15}";
        }
    }
}

