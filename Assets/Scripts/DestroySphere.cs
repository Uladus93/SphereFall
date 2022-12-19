using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySphere : MonoBehaviour
{
    void FixedUpdate()
    {
        if (transform.position.y <= -5.5)
        {
            Destroy(gameObject);
        }
    }
}
