using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        // Create customers
        var firstcustomer = new Customer("John Doe", new Address("123 Main St", "Anytown", "CA", "USA"));
        var secondcustomer = new Customer("Jane Smith", new Address("456 Elm St", "Othertown", "NY", "USA"));

        // Create products
        var firstproduct = new Product("Product 1", "P001", 10.99m, 2);
        var secondproduct = new Product("Product 2", "P002", 5.99m, 3);
        var thirdproduct = new Product("Product 3", "P003", 7.99m, 1);

        // Create orders
        var order1 = new Order(firstcustomer);
        order1.AddProduct(firstproduct);
        order1.AddProduct(secondproduct);

        var order2 = new Order(secondcustomer);
        order2.AddProduct(secondproduct);
        order2.AddProduct(thirdproduct);

        // Display order information
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel()); 
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotalCost():C}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.GetTotalCost():C}");
    }
}

