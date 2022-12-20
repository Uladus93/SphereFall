using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySphere : MonoBehaviour
{
    [SerializeField]private GameObject _gm;
    private MovingSphere _timeSpeed;
    private string _tag;
    private KeyCode _key;
    private int _color;
    private void Start()
    {
        _tag = gameObject.tag;
        _color = DetectingColor.Detecting(_tag);
        _key = (KeyCode)(_color + 256); // keypad 1-7
        _timeSpeed = _gm.GetComponent<MovingSphere>();
    }
    void FixedUpdate()
    {
        if (transform.position.y <= -5.5)
        {
            DelSphere();
            --Lifes.Life;
        }
        if (GameOver.End == false && Input.GetKey(_key))
        {
            DelSphere();
            Score.PlayerScore += (int)_timeSpeed.TimeSpeed;
        }
        
    }

    private void DelSphere()
    {
        Destroy(gameObject);
        GenerateSphere._isSphere[_color - 1] = false;
    }
}
