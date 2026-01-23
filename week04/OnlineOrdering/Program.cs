using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static Product p1 = new Product("Coca","14451",1.50,2);
    public static Product p2 = new Product("Fanta","14421",1.83,6);
    public static Product p3 = new Product("Bed","13451",23,7);
    public static Product p4 = new Product("Carlos","11451",10,4);
    public static Product p5 = new Product("Mentos","14441",1.67,1);
    static Product p6 = new Product("Grapes","14351",2,15);
    
    static void Main(string[] args)
    {
        string nameGuy1 = "Paolo Francesco";
        Address addressGuy1 = new Address("123 Salomon, Rivera, California, USA");
        Costumer guy1 = new Costumer(nameGuy1,addressGuy1);
        Order o1 = new Order(guy1);
        o1.AddToCart(p1);
        o1.AddToCart(p2);
        o1.AddToCart(p3);

        string nameGuy2 = "Carlos Gutierrez";
        Address addressGuy2 = new Address("456 Edward, Ottawa, Ottawa, Canada");
        Costumer guy2 = new Costumer(nameGuy2,addressGuy2);
        Order o2 = new Order(guy2);
        o2.AddToCart(p4);
        o2.AddToCart(p5);
        o2.AddToCart(p6);


        List<Order> orders = new List<Order>();
        orders.Add(o1);
        orders.Add(o2);
        foreach (Order o in orders)
        {
            Console.WriteLine($"{o.ShippingLabel()}\n\n{o.PackingLabel()}");
            Console.WriteLine($"Total price of the order: U$D {o.GetTotalPrice():F2}");
            Console.WriteLine("\n------------------------\n");
        }


    }
}