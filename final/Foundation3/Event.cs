public class Event
{
    protected string _title = "";
    protected string _date = "";
    protected string _description = "";
    protected string _time = "";
    protected string _address = "";


    public Event(string title, string date, string description, string time, string address){
        _title = title;
        _date = date;
        _description = description;
        _time = time;
        _address = address;
    }
    public string Standard(){
        return $"Event: {_title}\nDescription: {_description}\nDate: {_date}\nAddress: {_address}";
    }

    public string Full(){
        return $"";
    }

    public string Short(){
        return $"\nTitle: {_title}\nDate: {_date}";
    }
}