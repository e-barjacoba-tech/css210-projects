using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _productList = products;
    }

    public decimal GetTotalCost()
    {
        decimal cost = 0;
        
        foreach (Product product in _productList)
        {
            cost += product.OrderCost();
        }

        // adding the shipping tax
        if (IsAddressUSA())
        {
            cost += 5;
        }
        else
        {
            cost += 35;
        }

        return cost;
    }

    public bool IsAddressUSA()
    {
        return _customer.LivesInTheUSA();
    }

    public void DisplayPacketLbl()
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~ Packing Label ~~~~~~~~~~~~~~~~~~~~");
        foreach (Product product in _productList)
        {
            Console.WriteLine(product.ProductDetails());
        }
    }

    public void DisplayShippingLbl()
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~ Shipping Label ~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine($"{_customer.CostumerInfo()}");
    }
}
