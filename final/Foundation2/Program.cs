using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.SetProductId("8729");
        product1.SetName("Kit-Kat bars");
        product1.SetPrice(2);
        product1.SetQuantity(10);
        int total = product1.GetPriceTotal();
        string productDes = $"{product1.GetName()}|{product1.GetProductId()}|{product1.GetPriceTotal().ToString()}|{product1.GetQuantity().ToString()}";

        Order order1 = new Order();
        order1.AddProducts(productDes);

        product1.SetProductId("2508");
        product1.SetName("T-Shirts");
        product1.SetPrice(12);
        product1.SetQuantity(3);
        total = product1.GetPriceTotal();
        productDes = $"{product1.GetName()}|{product1.GetProductId()}|{product1.GetPriceTotal().ToString()}|{product1.GetQuantity().ToString()}";

        order1.AddProducts(productDes);

        Address address1 = new Address();
        address1.SetStreet("Stright Lane, PO 62779");
        address1.SetCity("Harisvile");
        address1.SetState("Ohio");
        address1.SetCountry("USA");
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


        Product product2 = new Product();
        Order order2 = new Order();
        product2.SetProductId("1161");
        product2.SetName("Learn to Play the Bagpips Book");
        product2.SetPrice(17);
        product2.SetQuantity(1);
        total = product2.GetPriceTotal();
        productDes = $"{product2.GetName()}|{product2.GetProductId()}|{product2.GetPriceTotal().ToString()}|{product2.GetQuantity().ToString()}";
        order2.AddProducts(productDes);

        product2.SetProductId("3957");
        product2.SetName("Health Bars");
        product2.SetPrice(5);
        product2.SetQuantity(5);
        total = product2.GetPriceTotal();
        productDes = $"{product2.GetName()}|{product2.GetProductId()}|{product2.GetPriceTotal().ToString()}|{product2.GetQuantity().ToString()}";
        order2.AddProducts(productDes);

        product2.SetProductId("0128");
        product2.SetName("USB-C Cable");
        product2.SetPrice(8);
        product2.SetQuantity(3);
        total = product2.GetPriceTotal();
        productDes = $"{product2.GetName()}|{product2.GetProductId()}|{product2.GetPriceTotal().ToString()}|{product2.GetQuantity().ToString()}";
        order2.AddProducts(productDes);

        Address address2 = new Address();
        address2.SetStreet("7809 Carr Place");
        address2.SetCity("Okotoks");
        address2.SetState("Alberta");
        address2.SetCountry("Canada");
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