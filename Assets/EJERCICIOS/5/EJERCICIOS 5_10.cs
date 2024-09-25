using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJERCICIOS5_9 : MonoBehaviour
{
    [SerializeField] int NUMERO = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (NUMERO <= 10) 
        {
            Debug.Log("frio");
        }
        else if (NUMERO > 10 && NUMERO <= 20)
        {
            Debug.Log("nublado");
        }
        else if (NUMERO >= 20 && NUMERO <= 30)
        {
            Debug.Log("caluroso");
        }
        else if(NUMERO >= 30)
        {
            Debug.Log("tropical");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
