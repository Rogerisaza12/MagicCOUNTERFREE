using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLives : MonoBehaviour
{ 
    public static int score;
    public Text scoretext1;
    public Text scoretext2;
    public Text scoretext3;
    public Text scoretext4;
    public Text scoretext5;
    public Text scoretext6;
    

    public void TwentyLives()
    {
        score = 20;
        SetCountText();
    }
    public void ThirtyLives()
    {
        score = 30;
        SetCountText();
    }
    public void FourtyLives()
    {
        score = 40;
        SetCountText();
    }

    public void SetCountText()
    {
        scoretext1.text = score.ToString();
        scoretext2.text = score.ToString();
        scoretext3.text = score.ToString();
        scoretext4.text = score.ToString();
        scoretext5.text = score.ToString();
        scoretext6.text = score.ToString();
    }
}
