public abstract class Activity
{
    protected string _date = "01 Jan 2000";
    protected int _length = 0; //In minutes

    public string GetDate(){
        return _date;
    }
    public void SetDate(string date){
        _date = date;
    }
    public int GetLength(){
        return _length;
    }
    public void SetLength(int length){
        _length = length;
    }

    public abstract float Distance();
    public abstract float CalculateSpeed();
    public abstract float CalculatePace();
    
    public virtual void GetSummary(Activity activity){
        string date = activity.GetDate();
        int length = activity.GetLength();
        float distance = activity.Distance();
        float speed = activity.CalculateSpeed();
        float pace = activity.CalculatePace();

        Console.WriteLine($"{date} Running ({length.ToString()} min)- Distance {distance.ToString()} km, Speed: {speed} kph, Pace: {pace} min per km");
    }
    
}