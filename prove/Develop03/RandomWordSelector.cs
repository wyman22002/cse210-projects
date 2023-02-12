using System;
using System.Collections;
using System.Collections.Generic;
public class RandomWordSelector
{

    public List<int> rndNumList;
    public int rndNum;
    public int totalNumberOfWords;
    //public string[] _VerseList = VerseHolder._Verse.Split(' ');
    //private int ListNum = _VerseList.Count;

    
    public List<int> ReplaceWords(List<int> usedNum) {
        Random rnd = new Random();

        VerseHolder holder1 = new VerseHolder();
        var _VerseList = holder1._Verse.Split(' ');

        var listTotal = _VerseList.Count();

        int chance = rnd.Next(listTotal);
        var used1 = new List<int>();
        var RndWordSelector = new RandomWordSelector();

        if (usedNum == null) {
            used1.Add(chance);
            RndWordSelector = RandomNumberHolder(used1, chance, listTotal);
        } else {
            RndWordSelector = RandomNumberHolder(usedNum, chance, listTotal);
        }

        

        int[] usedWords = new int[listTotal];
        Console.WriteLine(usedWords.ToList().ToString());

        return RndWordSelector.rndNumList;
    }

    public RandomWordSelector RandomNumberHolder(List<int> numberHolder, int rndNumber,int TotalNum) {
        Random rnd = new Random();
        int chance = rndNumber;
        List<int> numHold = new List<int>();
        numHold = numberHolder;
        //Console.WriteLine(chance);
        //Console.WriteLine(TotalNum);
        //Console.WriteLine(numberHolder[0]);


            if (numHold.Contains(chance)) {
                chance = rnd.Next(TotalNum);
            }
        

        numHold.Add(chance);
        var rndWordSelector = new RandomWordSelector();
        
        rndWordSelector.rndNumList = numberHolder;
        rndWordSelector.rndNum = chance;
        rndWordSelector.totalNumberOfWords = TotalNum;
        
        return rndWordSelector; 
    }

//        VerseHolder holder1 = new VerseHolder();
//        public string[] _VerseList = VerseHolder._Verse.Split(' ');


//      UsedWords = new list<int>();
/*    static string ReplaceWords() {
        do 
        {
            Random _randomNumber = new Random();
            _randomNumber.Next(ListNum);
            int UsedWordsTotal = UsedWords.Count();

            if (_randomNumber != UsedWords) {
                //garb the _randomNumber item to get the word from the verse list
                //for loop to convert every letter into a _underscore
                string word = _VerseList[_randomNumber];
                foreach (string letter in word) {
                    letter = "_";
                }
                UsedWords.Add(_randomNumber);
                LoopTimes += 1;

            } else if (UsedWordsTotal == ListNum) {
                //checks to see if all words have been replaced and if so ends the program
                Program.UserInput = "quit";
            }
        } while (LoopTimes > 3);
        
       //add all _VerseList items into a single string then return value to VerseHolder
        //foreach (word in _VerseList) {}
        
        return _VerseList;
    }
    public RandomWordSelector(){}*/
}
