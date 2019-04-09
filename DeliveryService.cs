using System;

namespace ProdDeliverybk1._7
{
    public class DeliveryService
        {
            /*
            Properties
            */
            public string Name { get; set; }

            public string TransitType { get; set; }

            /*
            Methods
            */
            public void Deliver(Product product, Customer customer)
            {
                Console.WriteLine($"Product delivered by {this.TransitType} to {customer.FullName}");
            }
        }
}
