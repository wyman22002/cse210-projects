using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("8729", "Kit-Kat bars", 2,  10);
        int total = product1.GetPriceTotal();
        string productDes = $"{product1.GetName()}|{product1.GetProductId()}|{product1.GetPriceTotal().ToString()}|{product1.GetQuantity().ToString()}";

        Order order1 = new Order();
        order1.AddProducts(productDes);

        Product product2 = new Product("2508", "T-Shirts", 12, 3);
        total = product2.GetPriceTotal();
        productDes = $"{product2.GetName()}|{product2.GetProductId()}|{product2.GetPriceTotal().ToString()}|{product2.GetQuantity().ToString()}";

        order1.AddProducts(productDes);

        Address address1 = new Address("Stright Lane, PO 62779", "Harisvile", "Ohio", "USA");
        string fullAddress = address1.SetCompleateAddress();

        Customer customer1 = new Customer();
        customer1.SetUserName("Steve Mine");
        bool country = customer1.CustomerAddress(address1);

        order1.AddCustomers(customer1.GetUserName());
        order1.AddCustomers(fullAddress);

        string packingLabel = order1.PackingLabel();
        string shippingLabel = order1.ShippingLabel();
        int priceTotal = order1.AddressCreator(country);
        Console.WriteLine("Packing Label:");
        Console.WriteLine(packingLabel);
        Console.WriteLine($"Total: ${priceTotal}.00");
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(shippingLabel);


        Console.WriteLine();


        Product product3 = new Product("1161", "Learn to Play the Bagpips Book", 17, 1);
        Order order2 = new Order();
        total = product3.GetPriceTotal();
        productDes = $"{product3.GetName()}|{product3.GetProductId()}|{product3.GetPriceTotal().ToString()}|{product3.GetQuantity().ToString()}";
        order2.AddProducts(productDes);

        Product product4 = new Product("3957", "Health Bars", 5, 5);
        total = product4.GetPriceTotal();
        productDes = $"{product4.GetName()}|{product4.GetProductId()}|{product4.GetPriceTotal().ToString()}|{product4.GetQuantity().ToString()}";
        order2.AddProducts(productDes);

        Product product5 = new Product("0128", "USB-C Cable", 8, 3);
        total = product5.GetPriceTotal();
        productDes = $"{product5.GetName()}|{product5.GetProductId()}|{product5.GetPriceTotal().ToString()}|{product5.GetQuantity().ToString()}";
        order2.AddProducts(productDes);

        Address address2 = new Address("7809 Carr Place", "Okotoks", "Alberta", "Canada");
        fullAddress = address2.SetCompleateAddress();

        Customer customer2 = new Customer();
        customer2.SetUserName("Regien Jenson");
        country = customer2.CustomerAddress(address2);

        order2.AddCustomers(customer2.GetUserName());
        order2.AddCustomers(fullAddress);

        packingLabel = order2.PackingLabel();
        shippingLabel = order2.ShippingLabel();
        priceTotal = order2.AddressCreator(country);
        Console.WriteLine("Packing Label:");
        Console.WriteLine(packingLabel);
        Console.WriteLine($"Total: ${priceTotal}.00");
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(shippingLabel);
    }
}