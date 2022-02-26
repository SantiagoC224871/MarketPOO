using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPOO
{
    public class Invoice : IPay
    {
        private string _products;

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public decimal ValueToPay()
        {
            return 10;
        }
        public override string ToString()
        {
            return $"RECEIPT\n------------------------------" +
                $"{base.ToString()}" +
                $"\n\tValue......:{$"{ValueToPay():C2}",15}";
        }

    }
}
