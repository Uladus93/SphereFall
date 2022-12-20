using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphere : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField]private float _speed;
    [SerializeField]private float _timeSpeed;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _speed = DetectingColor.Detecting(gameObject.tag);
        _timeSpeed = (_speed + Time.unscaledTime);
    }
    void Update()
    {
        _rb.MovePosition(transform.position + Vector3.down * Time.deltaTime * _timeSpeed);
    }
}
