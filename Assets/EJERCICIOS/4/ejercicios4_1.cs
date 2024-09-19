using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios4_1 : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(areaCirculo(8));
        Debug.Log(areaTriangulo(7, 8));
        Debug.Log(areaCuadrado(4));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float areaCirculo (float radioCirculo) 
    {
        float circulo = radioCirculo * radioCirculo * 3.14f;
        return circulo;
    }

    float areaTriangulo (float basse, float altura) 
    {
        float triangulo = (basse * altura) /2;
        return triangulo;
    }

    float areaCuadrado(float ladoCuadrado)
    {
        float cuadrado = ladoCuadrado *ladoCuadrado;
        return cuadrado;
    }


}
