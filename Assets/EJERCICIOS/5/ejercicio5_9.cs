using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int NUMERO = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        if (NUMERO ==1) 
        {
            Debug.Log("DAÑO = 350 VIDA = 650");
        }
        else if (NUMERO ==2) 
        {
            Debug.Log("DAÑO = 300 VIDA = 550");
        }
        else if (NUMERO ==3) 
        {
            Debug.Log("DAÑO = 300 VIDA = 500");
        }
        else if (NUMERO == 4)
        {
            Debug.Log("DAÑO = 310 VIDA = 460");
        }
        else if (NUMERO == 5)
        {
            Debug.Log("DAÑO = 280 VIDA = 490");
        }
        else if (NUMERO == 6)
        {
            Debug.Log("DAÑO = 360 VIDA = 520");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
