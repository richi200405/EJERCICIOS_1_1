using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios4_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        convertidor(5,"euro");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void convertidor(float cantidad, string tipo) 
    {
        if (tipo == "euro")
        {
            float cantidadConvert = cantidad * 1.11f;
            tipo = "dolar";
            Debug.Log ("son "+ cantidadConvert + " " + tipo);
            
        }
        else if (tipo == "dolar")
        {
            float cantidadConvert = cantidad / 1.11f;
            tipo = "euro";
            Debug.Log("son " + cantidadConvert + " " + tipo);

        }
    }



}
