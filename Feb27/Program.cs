using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb27
{
    class Program
    {
       public class Orderprocessor
        {
            private readonly Shippingcalculator_shippingCalculator;
            public Orderprocessor()
            {
                _shippingCalculator = new ShippingCalculator();

            }
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed");
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.Calculateshipping(order),
            ShippingDate = DateTime.Today.AddDays(1)


            };
        }


        }
    }

