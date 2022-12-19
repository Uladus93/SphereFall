using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySphere : MonoBehaviour
{
    private string _tag;
    private KeyCode _key;
    private void Start()
    {
        _tag = gameObject.tag;
        switch (_tag)
        {
            case "violet": 
                _key = (KeyCode)(Rainbow.violet + 256);
                break;
            case "indigo":
                _key = (KeyCode)(Rainbow.indigo + 256);
                break;
            case "blue":
                _key = (KeyCode)(Rainbow.blue + 256);
                break;
            case "green":
                _key = (KeyCode)(Rainbow.green + 256);
                break;
            case "yellow":
                _key = (KeyCode)(Rainbow.yellow + 256);
                break;
            case "orange":
                _key = (KeyCode)(Rainbow.orange + 256);
                break;
            case "red":
                _key = (KeyCode)(Rainbow.red + 256);
                break;
            default:
                break;
        }
    }
    void FixedUpdate()
    {
        if (transform.position.y <= -5.5)
        {
            Destroy(gameObject);
        }
        else if (Input.GetKey(_key))
        {
            Debug.Log(_key + _tag);
            Destroy(gameObject);
        }
    }
}
