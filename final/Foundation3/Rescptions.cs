public class Rescptions: Event
{
    private bool _rsvp = false;
    private string _email = "";
    public Rescptions(string title, string date, string description, string time, string address, bool rsvp, string email) : base(title, date, description, time, address)
    {
        _rsvp = rsvp;
        _email = email;
    }
    public string Full(){
        string rsvp = "";
        if(_rsvp == true){
            rsvp = "Yes";
            return $"Event: {_title}\nDescription: {_description}\nDate: {_date}\nAddress: {_address}\nRSVP: {rsvp}\nEmail for RSVP: {_email}";

        } else {
            rsvp = "No";
            return $"Event: {_title}\nDescription: {_description}\nDate: {_date}\nAddress: {_address}\nRSVP: {rsvp}";
        }
    }
}