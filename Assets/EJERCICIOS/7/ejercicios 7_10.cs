using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios7_10 : MonoBehaviour
{
    [SerializeField] int numero1; 
    [SerializeField] int numero2;
    // Start is called before the first frame update
    void Start()
    {
       
        int menor = Mathf.Min(numero1, numero2);
        int mayor = Mathf.Max(numero1, numero2);

        
        for (int i = menor; i <= mayor; i++)
        {
            string tipoNumero = (i >= 0) ? "positivo" : "negativo"; 
            string paridad = (i % 2 == 0) ? "par" : "impar";       

            Debug.Log(i + " es " + tipoNumero + " y " + paridad);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
