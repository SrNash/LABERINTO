using System.Collections.Generic;
using UnityEngine;

public class CollisiionDetect : MonoBehaviour
{
    [SerializeField]
    Material mt_Wall;
    [SerializeField]
    Material mt_WallChange;

    bool matChanged = false;
    float timerMTChange = 5f;

    private void Update()
    {
        if(matChanged) timerMTChange -= Time.deltaTime;
        if(timerMTChange <= 0.0f)
        {
            gameObject.GetComponent<MeshRenderer>().material = mt_Wall;
            matChanged = false;
            timerMTChange = 5f;
        }
    }

    //Función cambio de materiales de las paredes al detectar colisión
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log(col.gameObject.name);
            gameObject.GetComponent<MeshRenderer>().material = mt_WallChange;
            matChanged = true;
        }
        else if (col.gameObject.tag != "Player")
        {
            Debug.Log("Volviendo a cambiar el material");
            gameObject.GetComponent<MeshRenderer>().material = mt_Wall;
        }
    }    
}
