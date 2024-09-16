using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios3_3 : MonoBehaviour
{
    [SerializeField] int valor = 0;
    // Start is called before the first frame update
    void Start()
    {
        int doble = valor * 2;
        Debug.Log(doble);
        int triple = valor * 3;
        Debug.Log(triple);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
