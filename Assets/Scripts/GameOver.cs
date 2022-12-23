using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverCanvas;
    public static bool End { get; set; }
    private void FixedUpdate()
    {
        if (Lifes.Life < 1)
        {
            _gameOverCanvas.SetActive(true);
            End = true;
            PlayerContoller._pause = true;
        }
    }

    public static void Restart()
    {
        Lifes.Life = 3;
        Score.PlayerScore = 0;
        Timer.TimerTime = 0;
        foreach (var item in GenerateSphere.Spheres)
        {
            Destroy(item);
        }
        GenerateSphere.Spheres.Clear();
        End = false;
    }
}
