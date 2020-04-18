using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public List<Word> words;
    private bool hasActiveWord;
    public Word activeWord;
    public WordSpawner wordSpawner;

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        words.Add(word);
    }

    public void TypeLetter (char letter) 
    {
        if (hasActiveWord)
        {
            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else 
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }
        if(hasActiveWord && activeWord.WordTyped())
        {
            RemoveActiveWord();
        }
    }

    public void RemoveActiveWord()
    {
        hasActiveWord = false;
        words.Remove(activeWord);
    }

    private void Update() {
        if(hasActiveWord)
        {
            if(activeWord.RemoveAllLetter())
            {
                RemoveActiveWord();
            }
        }

        foreach(Word word in words)
        {
            if(word.RemoveAllLetter() && word.WordTyped())
            {
                words.Remove(word);
                break;
            }
        }

    }

}

