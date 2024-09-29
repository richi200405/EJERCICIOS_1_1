using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numeroMaximo;
    // Start is called before the first frame update
    void Start()
    {
        int numero = 1;

        while (numero <= numeroMaximo)
        {
            Debug.Log(numero);
            numero++;
        }

        //for (int numero = 1; numero <= numeroMaximo; numero++)
        //{
        //    Debug.Log(numero);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
