using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios7_7 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] private int numero2;
    // Start is called before the first frame update
    void Start()
    {
       
        int menor = Mathf.Min(numero1, numero2);
        int mayor = Mathf.Max(numero1, numero2);

        
        for (int i = menor; i <= mayor; i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
