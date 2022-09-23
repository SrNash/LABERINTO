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

    void Start()
    {
        SelectPosition();
    }

    void Awake()
    {
        randomPosInit = Random.Range(1,3);
        Debug.Log(randomPosInit);
    }

    void SelectPosition()
    {
        switch (randomPosInit)
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
        }
    }
}
