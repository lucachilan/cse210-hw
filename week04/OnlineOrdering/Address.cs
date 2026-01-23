public class Address
{
    string _street;
    string _city;
    string _state;
    string _country;

    public Address(string addressInfo)
    {
        string[] addressElements = addressInfo.Split(",");
        _street = addressElements[0].Trim();
        _city = addressElements[1].Trim();
        _state = addressElements[2].Trim();
        _country = addressElements[3].Trim();
    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        return false;
    }

    public string ShippingLabelAddress()
    {
        return $"{_street}, {_city}\n{_state}, {_country}";
    }

}