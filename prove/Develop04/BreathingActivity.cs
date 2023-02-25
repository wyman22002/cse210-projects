using System;
public class BreathingActivity : Activity
{
    public BreathingActivity(string activityType, string explanationMessage) : base(activityType, explanationMessage)
    {
        
    }

    private void BreathIn(int _wait) {
        string waitString = _wait.ToString();
        Console.Write($"Breath in...{waitString}");

        while (_wait != 0){
            Thread.Sleep(1000);
            Console.Write("\b \b \b");
            _wait -= 1;
            waitString = _wait.ToString();
            Console.Write($"{waitString}");
        }
        Console.Write("\b \b \b");
    }
    private void BreathOut(int _wait) {
        string waitString = _wait.ToString();
        Console.Write($"Breath out...{waitString}");

        while (_wait != 0){
            Thread.Sleep(1000);
            Console.Write("\b \b \b");
            _wait -= 1;
            waitString = _wait.ToString();
            Console.Write($"{waitString}");
        }
        Console.Write("\b \b \b");
    }

    public void BreathActivity(int _time) {
        Console.WriteLine("Get ready...");
        LoadAnime(5);
        Console.WriteLine();
        
        while (_time > 0){
            if (_time < 10 && _time > 0) {
                var smallTime = _time / 2;
                //Math.Floor(smallTime);
                BreathIn(smallTime);
                Console.WriteLine();
                BreathOut(smallTime);
                Console.WriteLine();
                _time -= _time;

            } else {
                BreathIn(5);
                Console.WriteLine();
                BreathOut(5);
                Console.WriteLine();
                _time -= 10;  
            }
            Console.WriteLine();
        }
    }
}