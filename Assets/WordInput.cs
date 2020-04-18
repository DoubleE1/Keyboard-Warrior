using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public TextManager textManager;
    // Update is called once per frame
    void Update()
    {
        foreach (char letter in Input.inputString)
        {
            textManager.TypeLetter(letter);
        }
    }
}
