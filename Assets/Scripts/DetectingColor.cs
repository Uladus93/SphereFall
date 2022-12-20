using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectingColor : MonoBehaviour
{
    public static int Detecting(string tag)
    {
        switch (tag)
        {
            case "violet":
                return  (int)Rainbow.violet;
            case "indigo":
                return  (int)Rainbow.indigo;
            case "blue":
                return  (int)Rainbow.blue;
            case "green":
                return  (int)Rainbow.green;
            case "yellow":
                return  (int)Rainbow.yellow;
            case "orange":
                return  (int)Rainbow.orange;
            case "red":
                return (int)Rainbow.red;
            default:
                break;
        }
        return 0;
    }
}
