using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJERCICIO1_1 : MonoBehaviour
{

    [SerializeField] string nombre = "Ricardo";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola mundo");
        Debug.Log("Este es el primer videojuego de " + nombre + " .Estoy aprendiendo C#");
        
    }

    // Update is called once per frame
    void Update()
    {
        //repetir a cada frame que se genera el mensaje 
        Debug.Log("Ha pasado un frame");
    }
}
