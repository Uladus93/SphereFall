using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _gameOver;
    [SerializeField] private float time;
    [SerializeField] private Material _violet;
    [SerializeField] private Material _orange;
    [SerializeField] private Color _violetColor;
    [SerializeField] private Color _orangeColor;

    private void Start()
    {
        time = 0;
        _violetColor = _violet.color;
        _orangeColor = _orange.color;
    }
    void Update()
    {
        time += Time.deltaTime;
        if ((int)time % 2 != 0)
        {
            _gameOver.color = _violetColor;
        }
        else
        {
            _gameOver.color = _orangeColor;
        }
    }
}
