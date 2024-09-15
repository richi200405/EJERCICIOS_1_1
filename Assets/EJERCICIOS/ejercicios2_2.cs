using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios2_2 : MonoBehaviour
{
    int vidas = 5;
    float exp = 0f;
    char carac = 'a';


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vidas + exp);
        float suma = vidas + exp;
        Debug.Log(suma);
        float resta = vidas - exp;
        Debug.Log(resta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
