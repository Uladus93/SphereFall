using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _gameOver;
    [SerializeField] private Button _restart;

    public static bool End { get; set; }
    private void FixedUpdate()
    {
        if (Lifes.Life < 1)
        {
            End = true;
            _gameOver.gameObject.SetActive(true);
            _restart.gameObject.SetActive(true);
        }
    }

    public static void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Lifes.Life = 3;
        Score.PlayerScore = 0;
        Timer.TimerTime = 0;
        GenerateSphere.Spheres.Clear();
        End = false;
    }
}
