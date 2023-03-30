public class Swimming : Activity
{
    private int _laps = 1;
    public int GetLaps(){
        return _laps;
    }
    public void SetLaps(int laps){
        _laps = laps;
    }

    public override float Distance(){
        return _laps * 50 / 1000;
    }
    public override float CalculateSpeed(){
        float distance = _laps * 50 / 1000f;
        return (distance / _length) * 60;
    }
    public override float CalculatePace(){
        float distance = _laps * 50 / 1000f;
        return _length / distance;
    }
    public override void GetSummary(Activity activity){
        string date = activity.GetDate();
        int length = activity.GetLength();
        float distance = activity.Distance();
        float speed = activity.CalculateSpeed();
        float pace = activity.CalculatePace();

        Console.WriteLine($"{date} Swimming ({length.ToString()} min)- Distance {distance.ToString("F2")} km, Speed: {speed.ToString("F2")} kph, Pace: {pace.ToString("F2")} min per km");
    }
}