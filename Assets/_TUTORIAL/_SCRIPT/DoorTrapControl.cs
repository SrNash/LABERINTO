using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrapControl : MonoBehaviour
{
    public Transform target;
    public Transform targetReset;
    public Vector3 offset;


    public bool isOpen = true;
    public bool isOpenClose = false;
    public bool isClose = false;

    public float timer;
    public float timeOpen;
    public float timeClose;

    float smoothSpeed = .125f;

    void Start()
    {
        targetReset = target;
    }

    void Update()
    {
        if (isOpen && timeOpen > 0)
        {
            timeOpen -= Time.deltaTime;

            if (timeOpen <= 0f)
            {
                isClose = true;
                OpeningClosing(isClose);
            }
        }
        if (isClose && timeClose > 0)
        {
            timeClose -= Time.deltaTime;

            if (timeClose <= 0f)
            {
                isOpen = true;
                OpeningClosing(!isOpen);
            }
            
        }
    }

    void OpeningClosing(bool isOpenClose)
    {
        if(isOpenClose)
        {
            Vector3 destPosition = target.position - offset;
            print(destPosition);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, destPosition, smoothSpeed);
            target.position = smoothedPosition;
            isOpen = false;
            timeOpen = 6f;
        }

        if(!isOpenClose)
        {
            Vector3 destPosition = target.position + (offset*7.5f);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, destPosition, smoothSpeed);
            target.position = smoothedPosition;
            isClose = false;
            timeClose = 4f;
        }
        timer = 7f;
    }
}
