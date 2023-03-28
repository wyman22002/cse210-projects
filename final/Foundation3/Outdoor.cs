public class Outdoor: Event
{
    private string _weather = "";
    public Outdoor(string title, string date, string description, string time, string address, string weather) : base(title, date, description, time, address)
    {
        _weather = weather;
    }
    public string Full(){
        return $"Event: {_title}\nDescription: {_description}\nDate: {_date}\nAddress: {_address}\nThe weather is expected to be {_weather}.";
    }
}