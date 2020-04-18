using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = {"boundary", "scale", "worry", "finger", "well-made", "upset", "bore", "tip", 
                                        "flagrant", "oven", "wind", "stuff", "page", "branch", "powerful", "drop", "impulse", 
                                        "labored", "soap", "premium", "hapless", "oil", "crowded", "marvelous", "tranquil", 
                                        "domineering", "hill", "prose", "cloth", "jittery", "unfasten", "ear", "possible", 
                                        "physical", "silent", "raspy", "rigid", "flashy", "chief", "real", "vivacious", 
                                        "oafish", "lace", "explode", "grumpy", "scold", "disastrous", "protective", "waiting", 
                                        "potato", "glass", "dizzy", "thought", "deeply", "improve", "flower", "faint", "eatable", 
                                        "ball", "crash", "heap", "standing", "broken", "squeamish", "cure", "history", "nosy", "true", 
                                        "lewd", "downtown", "meeting", "interesting", "melodic", "spring", "letter", "resonant", "pale", 
                                        "kindhearted", "perfect", "excite", "fantastic", "ritzy", "earthy", "bump", "rescue", "burst", 
                                        "snatch", "report", "silver", "stupid", "partner", "toys", "icy", "pine", "smooth", "beam", 
                                        "perform", "shocking", "educate", "lackadaisical"};
    public static string GetRandomWord(){
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}