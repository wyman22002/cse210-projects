public class Customer
{
    private string _userName = "";

    public string GetUserName(){
        return _userName;
    }
    public void SetUserName(string name){
        _userName = name;
    }

    public bool CustomerAddress(){
        Address address = new Address();
        bool country = address.InUSA();
        return country;
    }
}