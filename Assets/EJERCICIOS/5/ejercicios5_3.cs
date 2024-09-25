using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios5_3 : MonoBehaviour
{
    [SerializeField] int NUMERO = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        if (NUMERO < 9 && NUMERO > 0)
        {
            Debug.Log("si");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
