using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P001", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.50m, 2));
        order1.AddProduct(new Product("Keyboard", "P003", 45.00m, 1));
        
        Console.WriteLine("--- Order 1 Details ---");
        // 1. Removed redundant headers. The methods now provide them.
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        // 2. Changed method to GetTotalPrice and added currency formatting (:C).
        Console.WriteLine($"Total Price: {order1.GetTotalprice():C}\n");


        // --- Order 2 (Customer in Canada) ---
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Tablet", "P004", 299.99m, 1));
        order2.AddProduct(new Product("Stylus", "P005", 19.99m, 1));
        order2.AddProduct(new Product("Case", "P006", 39.99m, 1));

        Console.WriteLine("--- Order 2 Details ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.GetTotalprice():C}");
    }
}