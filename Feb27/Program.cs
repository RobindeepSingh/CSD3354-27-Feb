using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb27
{

    public class OrderProcessor
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
    public class ShippingCalculator { 
        public float CalculatorShipping(Order order) {

            if (order.TotalPrice < 30f) return order.Totalprice * 0.1f;
            return 0;
    }
}

    

