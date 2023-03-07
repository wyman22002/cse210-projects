using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal goal1 = new SimpleGoal();
        goal1.GoalCreation();

        DisplaySimple dis1 = new DisplaySimple();
        dis1.DisplayGoal();
    }
}