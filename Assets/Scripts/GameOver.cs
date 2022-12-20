using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
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
        }
    }
}
