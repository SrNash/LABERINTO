using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float posX, posY, posZ;
    public float speedPlayer = 1.5f;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mantener la posición en Y lo más cercano a 0
        posY = 0f;

        //Obtenemos los INPUTS
        posX = Input.GetAxis("Horizontal") * Time.deltaTime * speedPlayer;
        posZ = Input.GetAxis("Vertical") * Time.deltaTime * speedPlayer;
        
        transform.Translate(posX,posY,posZ);


        /// <summary>
        /// Rotacion del PJC
        /// </summary>
        float rotation = posX * rotationSpeed;
        if (posX > 0 )
        {
            transform.Rotate(0f, rotation, 0f);
        }else if(posX < 0)
        {
            transform.Rotate(0f, rotation, 0f);
        }
    }
}


//transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation, rotateSpeed * Time.deltaTime);