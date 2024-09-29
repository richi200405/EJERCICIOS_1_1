using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio7_13 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numero = 17; // Puedes cambiar este valor para probar con otros números
        bool esPrimo = EsNumeroPrimo(numero);
        Debug.Log(numero + " es primo: " + esPrimo);
    }
    bool EsNumeroPrimo(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (int i = 3; i <= Mathf.Sqrt(num); i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
