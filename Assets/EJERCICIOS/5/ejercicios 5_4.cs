using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios5_4 : MonoBehaviour
{
    [SerializeField] float NUMERO = 1;
    [SerializeField] float NUMERO2 = 2;
    // Start is called before the first frame update
    void Start()
    {
        if (NUMERO2 > 0) 
        { 
        float division = NUMERO/ NUMERO2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
