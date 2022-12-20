using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySphere : MonoBehaviour
{
    private string _tag;
    private KeyCode _key;
    private int _color;
    private void Start()
    {
        _tag = gameObject.tag;
        _color = DetectingColor.Detecting(_tag);
        _key = (KeyCode)(_color + 256); // keypad 1-7

    }
    void FixedUpdate()
    {
        if (transform.position.y <= -5.5)
        {
            DelSphere();
        }
        else if (Input.GetKey(_key))
        {
            DelSphere();
        }
    }

    private void DelSphere()
    {
        Destroy(gameObject);
        GenerateSphere._isSphere[_color - 1] = false;
    }
}
