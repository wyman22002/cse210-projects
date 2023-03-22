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

        Customer customer1 = new Customer();
        customer1.SetUserName("Steve Mine");
        bool country = customer1.CustomerAddress();

        Address address1 = new Address();
        address1.SetStreet("Stright Lane, PO 62779");
        address1.SetCity("Harisvile");
        address1.SetState("Ohio");
        address1.SetCountry("USA");
        string fullAddress = address1.SetCompleateAddress();

        Order order1 = new Order();

        order1.AddressCreator(country);
        order1.AddCustomers(customer1.GetUserName());
        order1.AddCustomers(fullAddress);
        order1.AddProducts(productDes);

        string packingLabel = order1.PackingLabel();
        string shippingLabel = order1.ShippingLabel();
        Console.WriteLine(packingLabel);
        Console.WriteLine();
        Console.WriteLine(shippingLabel);
    }
}