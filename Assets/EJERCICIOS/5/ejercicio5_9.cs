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
            Debug.Log("DA�O = 350 VIDA = 650");
        }
        else if (NUMERO ==2) 
        {
            Debug.Log("DA�O = 300 VIDA = 550");
        }
        else if (NUMERO ==3) 
        {
            Debug.Log("DA�O = 300 VIDA = 500");
        }
        else if (NUMERO == 4)
        {
            Debug.Log("DA�O = 310 VIDA = 460");
        }
        else if (NUMERO == 5)
        {
            Debug.Log("DA�O = 280 VIDA = 490");
        }
        else if (NUMERO == 6)
        {
            Debug.Log("DA�O = 360 VIDA = 520");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
