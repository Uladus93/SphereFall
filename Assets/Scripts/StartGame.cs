using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] private Button _start;
    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }
}
