public class Costumer
{
    string _name;
    Address _address;

    public Costumer(string name, Address address)
    {
        _address = address;
        _name = name;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string ShippingLabel()
    {
        return $"{_name}\n{_address.ShippingLabelAddress()}";
    }
}