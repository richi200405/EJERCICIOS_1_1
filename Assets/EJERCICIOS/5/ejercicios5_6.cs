using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios5_6 : MonoBehaviour
{
    [SerializeField] int NUMERO = 1;


    // Start is called before the first frame update
    void Start()
    {
        if (NUMERO % 10 == 0)
        {
            Debug.Log("es multiplo");
        }
        else
        {
            Debug.Log("no es multiplo");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
