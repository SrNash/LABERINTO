using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorTrap : MonoBehaviour
{
    public Transform target;
    public Vector3 rotator;
    public float smoothSpeed = .125f;

    void Update()
    {
        //target.Rotate(0f, 10f * smoothSpeed, 0f );    
        target.Rotate(rotator * smoothSpeed);
    }
}
