using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool InUSA()
    {
        if (_country.Equals("USA", StringComparison.CurrentCultureIgnoreCase))
        {
            return true;
        }
        return false;
    }

    public string GetCompleteAdress()
    {
        return $"{_streetAddress}\n {_city}, {_stateProvince}, {_country}";
    }
}