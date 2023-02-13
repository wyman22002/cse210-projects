using System;
using System.Collections;
using System.Collections.Generic;
/*
public class RandomWordSelector
{
    
    public List<int> ReplaceWords(List<int> usedNum) {
        Console.WriteLine();
        Console.WriteLine("Start of ReplaceWords");

        Random rnd = new Random();

        VerseHolder holder1 = new VerseHolder();
        var _VerseList = holder1._Verse.Split(' ');
        Console.Write(string.Join(" ", _VerseList));
        Console.WriteLine(" this is _VerseList");

        var listTotal = _VerseList.Count();


        int chance = rnd.Next(listTotal);
        var used1 = new List<int>();
        var RndWordSelector = new RandomWordSelector();

        if (usedNum == null) {
            used1.Add(chance);
            RndWordSelector = RandomNumberHolder(used1, chance, listTotal);

            Console.Write(RndWordSelector);
            Console.WriteLine(" RndWordSelector if null");

        } else {
            RndWordSelector = RandomNumberHolder(usedNum, chance, listTotal);
            Console.Write(RndWordSelector);
            Console.WriteLine(" RndWordSelector else");
        }

        

        int[] usedWords = new int[listTotal];

            Console.Write(RndWordSelector);
            Console.WriteLine(" RndWordSelector");
        Console.WriteLine("End of Replace words");
        Console.WriteLine();

        return RndWordSelector.rndNumList;
    }

    public RandomWordSelector RandomNumberHolder(List<int> numberHolder, int rndNumber,int TotalNum) {
        Console.WriteLine();
        Console.WriteLine("Start of RandomNumberHolder");

        Random rnd = new Random();
        int chance = rndNumber;
        List<int> numHold = new List<int>();
        numHold = numberHolder;
        Console.WriteLine(chance + " this is chance in RWS");
        Console.WriteLine(TotalNum + " this is TotalNum in RWS");
        Console.WriteLine(string.Join(" ",numberHolder) + " this is numberHolder in RWS");


            if (numHold.Contains(chance)) {
                chance = rnd.Next(TotalNum);
            }
        

        numHold.Add(chance);
        var rndWordSelector = new RandomWordSelector();
        
        rndWordSelector.rndNumList = numberHolder;
        Console.WriteLine(string.Join(" ", rndWordSelector.rndNumList) + " RWS before return numberHolder");
        rndWordSelector.rndNum = chance;
        Console.WriteLine(rndWordSelector.rndNum + " RWS before return chance");
        rndWordSelector.totalNumberOfWords = TotalNum;

        Console.WriteLine("End of RandomNumberHolder");
        Console.WriteLine();

        return rndWordSelector; 
    }
}
*/