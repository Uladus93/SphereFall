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
    private static bool _end = false;
    public static bool End
    {
        get { return _end; }
        set { _end = value; }
    }

    private void FixedUpdate()
    {
        if (Lifes.Life < 1)
        {
            End = true;
            _gameOver.gameObject.SetActive(true);
            _restart.gameObject.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Lifes.Life = 3;
        Score.PlayerScore = 0;
        Timer.TimerTime = 0;
        End = false;
    }
}
