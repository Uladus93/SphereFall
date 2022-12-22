using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
        Lifes.Life = 3;
        Score.PlayerScore = 0;
        Timer.TimerTime = 0;
        GenerateSphere.Spheres.Clear();
    }
}
