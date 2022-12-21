using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSphere : MonoBehaviour
{
    [SerializeField] GameObject[] _spheres = new GameObject[7];
    private static List<GameObject> _spheresList = new List<GameObject>();
    public static List<GameObject> Spheres
    {
        get { return _spheresList; }
        set { _spheresList = value; }
    }

    private float _timer = 0;
    private int _broadX = 8;
    private float _broadY = 5.5f;
    private float _broadZ = -4;
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
            int index = Random.Range(0, _spheres.Length);
            if (GameOver.End == false)
            {
                GameObject newSphere =  Instantiate(_spheres[index], _coord, Quaternion.identity);
                _spheresList.Add(newSphere);
            }
            _timer = 0;
        }
    }
}
