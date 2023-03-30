public class Running : Activity
{
    private float _distance = 1;
    public float GetDistance(){
        return _distance;
    }
    public void SetDistance(float distance){
        _distance = distance;
    }

    public override float Distance(){
        return _distance;
    }
    public override float CalculateSpeed(){
        float speed = _distance / _length;
        return speed * 60;
    }
    public override float CalculatePace(){
        return _length / _distance;
    }
    public override void GetSummary(Activity activity){
        string date = activity.GetDate();
        int length = activity.GetLength();
        float distance = activity.Distance();
        float speed = activity.CalculateSpeed();
        float pace = activity.CalculatePace();

        Console.WriteLine($"{date} Running ({length.ToString()} min)- Distance {distance.ToString("F2")} km, Speed: {speed.ToString("F2")} kph, Pace: {pace.ToString("F2")} min per km");
    }
}