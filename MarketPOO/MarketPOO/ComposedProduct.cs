using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPOO
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public string Products { get; set; }

        public override decimal ValueToPay()
        {
            return (Price);
        }
        public override string ToString()
        {
            return $"   {Id} {Description}" +
                $"\n\tProducts...:{$"{Products:C2}",15}" +
                $"\n\tDiscount...:{$"{Discount:P2}",15}" +
                $"\n\tValue......:{$"{ValueToPay():C2}",15}";
        }
    }
}

