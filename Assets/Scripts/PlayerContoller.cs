using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Control();
    }

    private void Control()
    {
        if (GameOver.End == false && Input.anyKeyDown)
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
                Destroy(GenerateSphere.Spheres[i]);
                GenerateSphere.Spheres.RemoveAt(i);
                break;
            }
        }
        if (isSphere == false)
        {
            Score.PlayerScore -= (int)Time.unscaledTime;
        }
        isSphere = false;
    }
}
