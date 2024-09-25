using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios5_2 : MonoBehaviour
{
    [SerializeField] int NUMERO = 1;
    [SerializeField] int NUMERO2 = 2;
    // Start is called before the first frame update
    void Start()
    {
        if (NUMERO < 3 && NUMERO2 < 3) 
        {
            Debug.Log("Son menores");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
