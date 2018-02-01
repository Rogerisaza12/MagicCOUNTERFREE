using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player1 : MonoBehaviour
{
    public GameObject gameScore;
    public Text scoretext1;
    
    public void Plus()
    {
        SetLives.score++;
        SetCountText();
    }
    public void Minus()
    {
        SetLives.score--;
        SetCountText();
        
    }
    public void SetCountText()
    {
        scoretext1.text = score.ToString();
    }
}
