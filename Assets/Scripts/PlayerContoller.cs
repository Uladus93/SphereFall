using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particle;
    private AudioSource _sound;
    private bool _isPlaying = true;
    [SerializeField] private GameObject _pauseScreen;
    [SerializeField] private GameObject _menuScreen;
    [SerializeField] private GameObject _gameOver;
    public static bool _pause;
    void Start()
    {
        _sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        Control();
    }

    private void Control()
    {
        if (Input.anyKeyDown)
        {
            if (!GameOver.End || !_pause)
            {
                if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    AddScore("red");
                }
                if (Input.GetKeyDown(KeyCode.Keypad2))
                {
                    AddScore("orange");
                }
                if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    AddScore("yellow");
                }
                if (Input.GetKeyDown(KeyCode.Keypad5))
                {
                    AddScore("green");
                }
                if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    AddScore("blue");
                }
                if (Input.GetKeyDown(KeyCode.Keypad8))
                {
                    AddScore("indigo");
                }
                if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    AddScore("violet");
                }
            }
            if (Input.GetKeyDown(KeyCode.P) && !_menuScreen.activeSelf && !_gameOver.activeSelf)
            {
                Pause(_pauseScreen);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (GameOver.End && _gameOver.activeSelf)
                {
                    _pause = true;
                }
                if (_menuScreen.activeSelf)
                {
                    Pause(_menuScreen);
                    GameOver.Restart();
                }
                else if (_pauseScreen.activeSelf)
                {
                    Pause(_pauseScreen);
                    GameOver.Restart();
                }
                else if (_gameOver.activeSelf)
                {
                    Pause(_gameOver);
                    GameOver.Restart();
                }
                else
                {
                    GameOver.Restart();
                }
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (_isPlaying)
                {
                    _sound.Pause();
                    _isPlaying = false;
                }
                else
                {
                    _sound.Play();
                    _isPlaying = true;
                }
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (_pauseScreen.activeSelf)
                {
                    Pause(_pauseScreen);
                    Pause(_menuScreen);
                }
                else if (_gameOver.activeSelf)
                {
                    Pause(_gameOver);
                    Pause(_menuScreen);
                }
                else
                {
                    Pause(_menuScreen);
                }
            }
        } 
    }

    private void AddScore(string colorSphere)
    {
        bool isSphere = false;
        for (int i = 0; i < GenerateSphere.Spheres.Count; i++)
        {
            if (GenerateSphere.Spheres[i].tag == colorSphere)
            {
                MovingSphere movingSphere = GenerateSphere.Spheres[i].GetComponent<MovingSphere>();
                Score.PlayerScore += (int)movingSphere.TimeSpeed;
                isSphere = true;
                MeshRenderer mr = GenerateSphere.Spheres[i].GetComponent<MeshRenderer>();
                ParticleSystem.MainModule particleMain = _particle.main;
                particleMain.startColor = mr.material.color;
                Instantiate(_particle, GenerateSphere.Spheres[i].transform.position, _particle.transform.rotation);
                Destroy(GenerateSphere.Spheres[i]);
                GenerateSphere.Spheres.RemoveAt(i);
                break;
            }
        }
        if (isSphere == false)
        {
            Score.PlayerScore -= DetectingColor.Detecting(colorSphere) * 2;
        }
        isSphere = false;
    }

    public void Pause(GameObject panel)
    {
        if (!_pause)
        {
            _pause = true;
            panel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            _pause = false;
            panel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
