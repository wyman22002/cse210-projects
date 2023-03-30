public class Cycling : Activity
{
    private float _speed = 1;
    public float GetSpeed(){
        return _speed;
    }
    public void SetSpeed(float speed){
        _speed = speed;
    }

    public override float Distance(){
        float pace = 60 / _speed;
        return pace * _length;
    }
    public override float CalculateSpeed(){
        return _speed;
    }
    public override float CalculatePace(){
        return 60 / _speed;
    }
    public override void GetSummary(Activity activity){
        string date = activity.GetDate();
        int length = activity.GetLength();
        float distance = activity.Distance();
        float speed = activity.CalculateSpeed();
        float pace = activity.CalculatePace();

        Console.WriteLine($"{date} Cycling ({length.ToString()} min)- Distance {distance.ToString("F2")} km, Speed: {speed.ToString("F2")} kph, Pace: {pace.ToString("F2")} min per km");
    }
}