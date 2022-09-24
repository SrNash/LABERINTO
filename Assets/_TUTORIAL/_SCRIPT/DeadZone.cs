using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeadZone : MonoBehaviour
{
    [SerializeField]
    GameObject deadCanvas;
    [SerializeField]
    TextMeshProUGUI textTimer;

    [SerializeField]
    float timeRecord;
    [SerializeField]
    bool isPlay;
    
    void Awake()
    {
        isPlay = true;
    }
    void Update()
    {
        if (isPlay)
        {
            timeRecord += Time.deltaTime;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("PLAYER");
            deadCanvas.SetActive(true);
            other.GetComponent<PlayerController>().enabled = false;
            isPlay = false;
            textTimer.text = timeRecord.ToString("f0") + "   segundos";
        }
    }
}
