using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControl : MonoBehaviour
{
    [SerializeField]
    GameObject playerController;
    [SerializeField]
    GameObject camPrefab;

    public Transform pointA, pointB, pointC;
    public int randomPosInit;


    void Awake()
    {
        randomPosInit = Random.Range(1,4);
        Debug.Log(randomPosInit);
        SelectPosition();
    }

    void SelectPosition()
    {
      /*  switch (randomPosInit)
        {
            case 1:
                Instantiate(playerController, pointA.position, Quaternion.identity);
                Instantiate(camPrefab, pointA.position, Quaternion.identity);
                Debug.Log("caso 1");
                break;
            case 2:
                Instantiate(playerController, pointB.position, Quaternion.identity);
                Instantiate(camPrefab, pointB.position, Quaternion.identity);
                Debug.Log("caso 2");
                break;
            case 3:
                Instantiate(playerController, pointC.position, Quaternion.identity);
                Instantiate(camPrefab, pointC.position, Quaternion.identity);
                Debug.Log("caso 3");
                break;
        }*/
        if (randomPosInit == 1)
        {
            playerController.transform.position = pointA.position;
            camPrefab.transform.position = pointA.position;
        }else if (randomPosInit == 2)
        {
            playerController.transform.position = pointB.position;
            playerController.transform.rotation = pointB.rotation;
            camPrefab.transform.position = pointB.position;
        }else if (randomPosInit == 3)
        {
            playerController.transform.position = pointC.position;
            playerController.transform.rotation = pointC.rotation;
            camPrefab.transform.position = pointC.position;
        }
    }
}
