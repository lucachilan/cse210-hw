public class Product
{
    string _name;
    string _id;
    double _price;
    int _quantity;
    
    public Product(string name, string id, double price, int quant)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quant;

    }
    public double ProductTotalPrice()
    {
        return _price*_quantity;
    }
    public string PackingLabel()
    {
        return $"{_quantity} - {_name} | {_id}";   
    }

    
}