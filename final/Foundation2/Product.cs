public class Product
{
    private string _name = "";
    private string _productId = "0";
    private int _price = 0;
    private int _quantity = 0;
    private int _priceTotal = 0;

    public string GetName(){
        return _name;
    }
    public void SetName(string name){
        _name = name;
    }
    public string GetProductId(){
        return _productId;
    }
    public void SetProductId(string id){
        _productId = id;
    }
    public int GetPrice(){
        return _price;
    }
    public void SetPrice(int price){
        _price = price;
    }
    public int GetQuantity(){
        return _quantity;
    }
    public void SetQuantity(int quantity){
        _quantity = quantity;
    }
    public int GetPriceTotal(){
        return _price * _quantity;
    }
}