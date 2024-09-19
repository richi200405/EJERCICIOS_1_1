using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejericico4_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(areaCirculo(8, "euro"));
        Debug.Log(areaTriangulo(7, 8, "euro"));
        Debug.Log(areaCuadrado(4, "euro"));


    }

    // Update is called once per frame
    void Update()
    {

    }




    float areaCirculo(float radioCirculo, string tipo)
    {
        float circulo = radioCirculo * radioCirculo * 3.14f;
        convertidor(circulo, "euro");
        return circulo;
        
    }

    float areaTriangulo(float basse, float altura, string tipo)
    {
        float triangulo = (basse * altura) / 2;
        convertidor(triangulo, "euro");
        return triangulo;
        
    }

    float areaCuadrado(float ladoCuadrado, string tipo)
    {
        float cuadrado = ladoCuadrado * ladoCuadrado;
        convertidor(cuadrado, "euro");
        return cuadrado;
        
    }





    void convertidor(float cantidad, string tipo)
    {
        if (tipo == "euro")
        {
            float cantidadConvert = cantidad * 1.11f;
            tipo = "dolar";
            Debug.Log("son " + cantidadConvert + " " + tipo);

        }
        else if (tipo == "dolar")
        {
            float cantidadConvert = cantidad / 1.11f;
            tipo = "euro";
            Debug.Log("son " + cantidadConvert + " " + tipo);

        }
    }


}
