using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallSpeed = 1f;
    public TextManager textManager;
    public bool reached;

    public void SetWord (string word)
    {
        text.text = word;
    }

    public void RemoveLetter ()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.cyan;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    public bool CheckDistance()
    {
        Vector2 limitRange = new Vector2(Random.Range(-2.5f, 2.5f), -7f);

        if(Vector2.Distance(transform.position, limitRange) <= 1f)
        {
            reached = true;
        }
        return reached;
    }

    private void Update() {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0);
    }
}
