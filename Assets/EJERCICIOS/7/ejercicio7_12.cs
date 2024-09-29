using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio7_12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int resultado = SumarTodosLosNumeros(3, 7);
        Debug.Log("La suma de todos los números es: " + resultado);
    }
    int SumarTodosLosNumeros(int a, int b)
    {
        int suma = 0;
        for (int i = Mathf.Min(a, b); i <= Mathf.Max(a, b); i++)
        {
            suma += i;
        }
        return suma;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
