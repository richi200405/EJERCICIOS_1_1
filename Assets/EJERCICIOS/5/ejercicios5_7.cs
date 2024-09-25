using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios5_7 : MonoBehaviour
{
    [SerializeField] int NUMERO = 1;
    [SerializeField] int NUMERO2 = 5;
    [SerializeField] int NUMERO3 = 6;
    // Start is called before the first frame update
    void Start()
    {
        if (NUMERO > NUMERO2 && NUMERO > NUMERO3)
        {
            Debug.Log("1 primero");
        }
        if (NUMERO2 > NUMERO && NUMERO2 > NUMERO3)
        {
            Debug.Log("2 primero");
        }
        if (NUMERO3 > NUMERO2 && NUMERO3 > NUMERO)
        {
            Debug.Log("3 primero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
