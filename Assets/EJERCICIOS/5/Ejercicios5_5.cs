using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios5_5 : MonoBehaviour
{
    [SerializeField] float NUMERO = 6;
    
    // Start is called before the first frame update
    void Start()
    {
        if (NUMERO % 2 == 0)
        {
            Debug.Log("es par");
        }
        else
        {
            Debug.Log("es inpar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
