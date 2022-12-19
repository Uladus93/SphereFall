using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSphere : MonoBehaviour
{
    [SerializeField] GameObject[] _spheres = new GameObject[7];
    private float _timer = 0;
    private int _broadX = 8;
    private byte _broadY = 7;
    private sbyte _broadZ = -4;
    private float _rnd;
    private Vector3 _coord;

    void Start()
    {

    }

    void FixedUpdate()
    {
        _timer += Time.deltaTime;
        if (_timer >= 2)
        {
            _rnd = Random.Range(-_broadX, _broadX);
            _coord = new Vector3(_rnd, _broadY, _broadZ);
            Instantiate(_spheres[Random.Range(0, _spheres.Length)], _coord, Quaternion.identity);
            _timer = 0;
        }
    }
}
