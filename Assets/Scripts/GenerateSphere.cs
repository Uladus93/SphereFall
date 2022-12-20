using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSphere : MonoBehaviour
{
    [SerializeField] GameObject[] _spheres = new GameObject[7];
    public static bool[] _isSphere = new bool[7];
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
        if (_timer >= 0.5)
        {
            _rnd = Random.Range(-_broadX, _broadX);
            _coord = new Vector3(_rnd, _broadY, _broadZ);
            int index = Random.Range(0, _spheres.Length);
            if (_isSphere[index] == false)
            {
                Instantiate(_spheres[index], _coord, Quaternion.identity);
                _isSphere[index] = true;
            }
            _timer = 0;
        }
    }
}
