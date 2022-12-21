using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphere : MonoBehaviour
{
    private Rigidbody _rb;
    private MeshRenderer _mr;
    private float _speed;
    [SerializeField]private float timeSpeed;
    public float TimeSpeed
    {
        get { return timeSpeed; }
        set
        {
            timeSpeed = value;
            if (TimeSpeed > 40)
            {
                TimeSpeed = 40;
            }
        }
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _mr = GetComponent<MeshRenderer>();
        _speed = DetectingColor.Detecting(gameObject.tag);
        TimeSpeed = _speed + Time.unscaledTime / 10;
    }
    void Update()
    {
        _rb.MovePosition(transform.position + Vector3.down * Time.deltaTime * timeSpeed);
    }
}
