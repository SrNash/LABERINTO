using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseDoor : MonoBehaviour
{
   public Transform targetLeft;
   public Vector3 openPosLeft;
   public Vector3 closePosLeft;
   public Transform targetRight;
   public Vector3 openPosRight;
   public Vector3 closePosRight;
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
        //targetReset = target;
    }

    void Update()
    {
        if (isOpen && timeOpen > 0)
        {
            timeOpen -= Time.deltaTime;

            if (timeOpen <= 0)
            {
                targetLeft.Translate(openPosLeft);
                targetRight.Translate(openPosRight);
                timer -= Time.deltaTime;
                isClose = true;
                timeClose = 4f;
            }
           
        }
        if (isClose && timeClose > 0)
        {
            timeClose -= Time.deltaTime;

            if (timeClose <= 0f)
            {
                targetLeft.Translate(closePosLeft);
                targetRight.Translate(closePosRight);
                timer -= Time.deltaTime;
                isOpen = true;
                timeOpen = 6f;
                //OpeningClosing(!isOpen);
            }
            
        }
    }

    void OpeningClosing(bool isOpenClose)
    {
        if(isOpenClose)
        {
            /*Vector3 destPosition = target.position - offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, closePos, smoothSpeed);
            target.position = smoothedPosition;*/
            targetLeft.Translate(closePosLeft);
            targetRight.Translate(closePosRight);
            isOpen = false;
            timeOpen = 6f;
        }

        if(!isOpenClose)
        {
            /*Vector3 destPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, openPos, smoothSpeed);
            target.position = smoothedPosition;*/
            targetLeft.Translate(openPosLeft);
            targetRight.Translate(openPosRight);
            isClose = false;
            timeClose = 4f;
        }
        timer = 7f;
    }
}
