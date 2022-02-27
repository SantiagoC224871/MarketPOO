namespace MarketPOO
{
    public class VariablePriceProduct : Product
    {
        public string ?Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return (Price * (decimal)Quantity * (decimal)Tax) + (Price * (decimal)Quantity);
        }
        public override string ToString()
        {
            return $"   {Id} {Description}" +
                $"\n\tMeasurement: {Measurement}" +
                $"\n\tQuantity...:{$"{Quantity:F2}",15}" +
                $"\n\tPrice......:{$"{Price:C2}",15}" +
                $"\n\tTax........:{$"{Tax:P2}",15}" +
                $"\n\tValue......:{$"{ValueToPay():C2}",15}";
        }
    }
}
