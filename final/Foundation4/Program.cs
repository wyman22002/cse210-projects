using System;

class Program
{
    static void Main(string[] args)
    {
        Running rActivity = new Running();
        rActivity.SetDate("13 May 2023");
        rActivity.SetLength(35);
        rActivity.SetDistance(8);
        Cycling cActivity = new Cycling();
        cActivity.SetDate("01 July 2023");
        cActivity.SetLength(40);
        cActivity.SetSpeed(23);
        Swimming sActivity = new Swimming();
        sActivity.SetDate("20 October 2023");
        sActivity.SetLength(33);
        sActivity.SetLaps(20);

        List<Activity> activities = new List<Activity>();
        activities.Add(rActivity);
        activities.Add(cActivity);
        activities.Add(sActivity);

        
        foreach(Activity activity in activities){
            activity.GetSummary(activity);
        }
        
    }
}