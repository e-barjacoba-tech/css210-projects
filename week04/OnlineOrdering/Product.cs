using System;
using System.Reflection.Metadata.Ecma335;

public class Product
{
    private string _productName;
    private int _productID;
    private int _price;
    private int _quantity;

    public Product(string name, int id, int price, int quantity)
    {
        _productName = name;
        _productID = id;
        _price = price;
        _quantity = quantity;
    }

    public decimal OrderCost()
    {
        return _quantity * _price;
    }

    //I had to add a getter for the Order class so it could had access to some data

    public string ProductDetails()
    {
        return $"{_productID}: {_productName} ({_quantity} items of this product)";
    }
}