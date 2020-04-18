using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word{

    public string word;
    private int typeIndex;
    private int indexDif;
    WordDisplay display;
    public Word(string _word, WordDisplay _display){
        word = _word;
        typeIndex = 0;
        indexDif = 0;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter(){
        typeIndex++;
        indexDif = word.Length - typeIndex;
        display.RemoveLetter();
    }

    public void RemoveAllLetter()
    {
        for(int i = 0; i < indexDif; i++)
        {
            TypeLetter();
        }
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
