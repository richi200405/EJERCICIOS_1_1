using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios7_6 : MonoBehaviour
{
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()
    {
        int numero = num;

        while (numero >= -num)
        {
            Debug.Log(numero);
            numero--;
        }

        //for (int numero = num; numero >= -num; numero--)
        //{
        //    Debug.Log(numero);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
