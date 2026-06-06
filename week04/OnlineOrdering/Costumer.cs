using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInTheUSA()
    {
        return _address.InUSA();
    }

    public string CostumerInfo()
    {
        return $"To: {_name} \n {_address.GetCompleteAdress()}";
    }
}