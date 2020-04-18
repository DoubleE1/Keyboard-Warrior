using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word{

    public string word;
    private int typeIndex;
    private int indexDif;
    WordDisplay display;
    
    public Word(string _word, WordDisplay _display)
    {
        word = _word;
        typeIndex = 0;
        indexDif = word.Length;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        indexDif = word.Length - typeIndex;
        display.RemoveLetter();
    }

    public bool RemoveAllLetter()
    {
        bool removeAll = display.CheckDistance();
        if(removeAll)
        {
            int temp = indexDif;
            for(int i = 0; i < temp; i++)
            {
                TypeLetter();
            }
        }
        return removeAll;
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if(wordTyped)
        {
            display.RemoveWord();
        }
        return wordTyped;
    }
}
