using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios4_2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log( construitNombre("Ricardo", "Peña", "Hernández",5 ));  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string construitNombre(string nombre, string apellido1, string apellido2, int edad)
    {
        string nombrecompleto = "La persona se llama " + nombre + apellido1 + apellido2 + "y tiene " + edad + "años";
        return nombrecompleto;
    }
}
