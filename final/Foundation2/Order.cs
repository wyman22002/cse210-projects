public class Order
{
    private int _Shipping = 0;

    private List<string> _products = new List<string>();
    private List<string> _customers = new List<string>();

    public void AddCustomers(string customer){
        _customers.Add(customer);
    }
    public void AddProducts(string product){
        _products.Add(product);
    }

    public string PackingLabel(){
        //0           |1 |2    |3
        //Product Name|ID|Price|Quantity
        //Only need name and ID
        int priceTotal = 0;
        string label = "";
        foreach (string product in _products)
        {
            string[] products = product.Split("|");
            string name = products[0];
            string id = products[1];
            int price = int.Parse(products[2]);
            priceTotal += price;
            label += $"{name} {id}";
        }
        priceTotal += _Shipping;
        return label;
    }

    public string ShippingLabel() {
        //Name|Address

        string name = _customers[0];
        string address = _customers[1];
        return $"{name}\n{address}";
    }

    public void AddressCreator(bool country){
        if (country == true){
            _Shipping = 5;
        } else {
            _Shipping = 35;
        }
    }
}