using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particle;
    public GameObject _pauseScreen;
    private bool _pause;

    void Start()
    {
    }

    void Update()
    {
        Control();
    }

    private void Control()
    {
        if (Input.anyKeyDown)
        {
            if (!GameOver.End && !_pause)
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
            if (Input.GetKeyDown(KeyCode.M))
            {
                _pause = false;
                SceneManager.LoadScene(0);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                Pause();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                GameOver.Restart();
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

    void Pause()
    {
        if (!_pause)
        {
            _pause = true;
            _pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            _pause = false;
            _pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }

}
