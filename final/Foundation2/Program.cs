using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("532 S 2nd E", "Rexburg", "ID", "US");
        Customer customer1 = new Customer("Thomas Ricks", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Jordan Tshirt", "0718NBA987", 19.99, 2);
        Product product2 = new Product("Pack of Socks", "932TAG095", 5.99, 7);
        Product product3 = new Product("Tie", "111TIE222", 2.99, 1);        
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        Console.WriteLine(order1.CreatePackingLabel());
        Console.WriteLine(order1.CreateShippingLabel());

        Console.WriteLine();

        Address address2 = new Address("1900 Heritage Dr", "Calgary", "AB", "Canada");
        Customer customer2 = new Customer("Heritage", address2);
        Order order2 = new Order(customer2);
        Product product4 = new Product("Baseball Tshirt", "007MLB908", 14.99, 4);
        Product product5 = new Product("Baseball Cap", "228MLB546", 27.99, 1);
        Product product6 = new Product("Cleats", "875SHO903", 39.99, 1);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        Console.WriteLine(order2.CreatePackingLabel());
        Console.WriteLine(order2.CreateShippingLabel());
    }
}
