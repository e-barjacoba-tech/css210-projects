using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //First order
        Address addr1 = new Address("Av.Colon 4132", "Cordoba City", "Cordoba", "Argentina");
        Customer customer1 = new Customer("Martin Lopez", addr1);

        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Nintendo Switch 2", 0100, 400, 3));
        products1.Add(new Product("1989 TV", 0013, 20, 2));

        Order order1 = new Order(customer1, products1);

        order1.DisplayPacketLbl();
        order1.DisplayShippingLbl();
        Console.WriteLine($"\nTotal Cost: ${order1.GetTotalCost()}");

        Console.WriteLine("\n");

        //Second Order
        Address addr2 = new Address("460 A Street", "Provo", "Utah", "USA");
        Customer customer2 = new Customer("James Ten", addr2);

        List<Product> products2 = new List<Product>();
        products2.Add(new Product("Soap", 0001, 1, 12));
        products2.Add(new Product("Laptop", 0170, 200, 3));

        Order order2 = new Order(customer2, products2);

        order2.DisplayPacketLbl();
        order2.DisplayShippingLbl();
        Console.WriteLine($"\nTotal Cost: ${order2.GetTotalCost()}");
    }
}