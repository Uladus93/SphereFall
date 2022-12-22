using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private static int playerScore = 0;
    [SerializeField] private TextMeshProUGUI _score;
    public static int PlayerScore
    {
        get { return playerScore; }
        set 
        {
            playerScore = value;
            if (PlayerScore < 0)
            {
                PlayerScore = 0;
            }
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        _score.text = $"Score: {PlayerScore}";
    }
}
