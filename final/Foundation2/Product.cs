public class Product
{
    private string _name = "";
    private string _productId = "0";
    private int _price = 0;
    private int _quantity = 0;
    private int _priceTotal = 0;

    public Product(string name, string productId, int price, int quantity){
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public string GetName(){
        return _name;
    }
    public string GetProductId(){
        return _productId;
    }
    public int GetPrice(){
        return _price;
    }
    public int GetQuantity(){
        return _quantity;
    }
    public int GetPriceTotal(){
        return _price * _quantity;
    }
}