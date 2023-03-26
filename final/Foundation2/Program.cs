using System;

class Program {
    static void Main(string[] args) {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Product[] products1 = {
            new Product("Widget A", 1001, 10.00, 3),
            new Product("Widget B", 1002, 20.00, 2)
        };
        Order order1 = new Order(customer1, products1);
        
        Address address2 = new Address("456 Main St", "Othertown", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Product[] products2 = {
            new Product("Widget C", 1003, 15.00, 1),
            new Product("Widget D", 1004, 25.00, 4),
            new Product("Widget E", 1005, 5.00, 2)
        };
        Order order2 = new Order(customer2, products2);
        
        Console.WriteLine("Order 1:");
        Console.WriteLine($"Total price:");
        Console.WriteLine(order1.GetTotalPrice());
        Console.WriteLine("Packing label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nOrder 2:");
        Console.WriteLine($"Total price: {order2.GetTotalPrice()}");
        Console.WriteLine("Packing label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping label:");
        Console.WriteLine(order2.GetShippingLabel());
}
}