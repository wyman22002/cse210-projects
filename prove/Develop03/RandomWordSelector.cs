using System;
using System.Collections.Generic;
using VerseHolder;

public class RandomWordSelector
{
    private int LoopTimes = 0;
    public string[] _VerseList = VerseHolder._Verse.Split(' ');
    private int ListNum = _VerseList.Count;
    list<int> UsedWords = new list<int>();
    static void ReplaceWords() {
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
       return _VerseList;
    }
    public RandomWordSelector(){}
}