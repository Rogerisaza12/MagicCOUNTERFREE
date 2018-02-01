using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    public void TwoPlayers()
    {
        SceneManager.LoadScene("2Player");
    }
    public void ThreePlayers()
    {
        SceneManager.LoadScene("3Player");
    }
    public void FourPlayers()
    {
        SceneManager.LoadScene("4Player");
    }
    public void FivePlayers()
    {
        SceneManager.LoadScene("5Player");
    }
    public void SixPlayers()
    {
        SceneManager.LoadScene("6Player");
    }
    public void Back()
    {
        SceneManager.LoadScene("Main");
    }


}
