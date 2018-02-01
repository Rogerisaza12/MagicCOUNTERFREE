using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLives : MonoBehaviour
{
    public void TwentyLives()
    {
        Player1.score = 20;
        Player2.score = 20;
        Player3.score = 20;
        Player4.score = 20;
        Player5.score = 20;
    }
    public void ThirtyLives()
    {
        Player1.score = 30;
        Player2.score = 30;
        Player3.score = 30;
        Player4.score = 30;
        Player5.score = 30;
    }
    public void FourtyLives()
    {
        Player1.score = 40;
        Player2.score = 40;
        Player3.score = 40;
        Player4.score = 40;
        Player5.score = 40;
    }
}
