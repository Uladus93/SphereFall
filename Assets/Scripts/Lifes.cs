using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lifes : MonoBehaviour
{
    private static byte life = 3;
    [SerializeField] private TextMeshProUGUI _lifes;
    public static byte Life
    { 
        get { return life; } 
        set 
        { 
            life = value;
            if (Life < 0)
            {
                Life = 0;
            }
            if (Life > 3)
            {
                Life = 0;
            }
        } 
    }

    void Update()
    {
        if (life <= 1)
        {
            _lifes.text = $"Life: {life}";
        }
        else _lifes.text = $"Lifes: {life}";
    }
}
