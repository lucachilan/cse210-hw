using System.ComponentModel;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    Costumer _costumer;
    List<Product> _shoppingCart = new List<Product>();


    public Order(Costumer c)
    {
        _costumer = c;
    }

    public void AddToCart(Product p)
    {
        _shoppingCart.Add(p);
    }

    public double GetTotalPrice()
    {
        int shippingCost = 0;
        if (_costumer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        double total = _shoppingCart.Sum(p => p.ProductTotalPrice()) + shippingCost;
        return total;
    }
    
    
    public string PackingLabel()
    {
        string finalLabel = "----Products List----\n";
        foreach ( Product p in _shoppingCart)
        {
            finalLabel += p.PackingLabel() + "\n";
        }
        return finalLabel;
    }

    public string ShippingLabel()
    {
        return _costumer.ShippingLabel();
    }

}