using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios2_4 : MonoBehaviour
{
    int vidas = 5;


    // Start is called before the first frame update
    void Start()
    {
        vidas += 77;
        Debug.Log(vidas);
        vidas -= 3;
        Debug.Log(vidas);
        vidas *= 4;
        Debug.Log(vidas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
