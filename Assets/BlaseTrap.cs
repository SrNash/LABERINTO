using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlaseTrap : MonoBehaviour
{
    [SerializeField]
    Transform bladeTr;
    [SerializeField]
    MeshRenderer meshRCyl;
    [SerializeField]
    MeshRenderer meshRBlade;
    [SerializeField]
    float bladeSpeed = .125f;
    [SerializeField]
    Vector3 balanceDir;
    [SerializeField]
    bool isActive = false;
    [SerializeField]
    float timer;
    
    void OnTriggerEnter(Collider other)
    {
        isActive = true;
        timer += Time.deltaTime;
    }
    
    private void Update()
    {
        if (timer >= 20f)
        {
            isActive = false;
        }
    }
    
    void FixedUpdate()
    {
        if (isActive)
        {
            meshRCyl.enabled = true;
            meshRBlade.enabled = true;

            if (meshRCyl.enabled == true && isActive)
            {
                bladeTr.Rotate(balanceDir * bladeSpeed);
            }

        }else if (!isActive)
        {
            meshRCyl.enabled = false;
            meshRBlade.enabled = false;
        }
    }
}
