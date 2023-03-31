public class Lectures: Event
{
    private string _speakers = "";
    private int _capacity = 0;
    public Lectures(string title, string date, string description, string time, string address, string speakers, int capacity) : base(title, date, description, time, address)
    {
        _speakers = speakers;
        _capacity = capacity;
    }
    public string LecturesFull(){
        return $"Event: {_title}\nDescription: {_description}\nDate: {_date}\nAddress: {_address}\nSpeaker: {_speakers}\nCapacity: {_capacity}";
    }
}