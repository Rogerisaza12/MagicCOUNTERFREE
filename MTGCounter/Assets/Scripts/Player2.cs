using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{
    public static int score;
    public Text scoretext;

    void Update()
    {
        SetCountText();
    }

    public void Plus()
    {
        score++;
        SetCountText();
    }
    public void Minus()
    {
        score--;
        SetCountText();

    }
    public void SetCountText()
    {
        scoretext.text = score.ToString();
    }
}
