using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJERCICIOS_5_1 : MonoBehaviour
{
    [SerializeField] int NUMERO = 1;
    [SerializeField] int NUMERO2 =2 ;
    // Start is called before the first frame update
    void Start()
    {
        if (NUMERO == NUMERO2)
        {
            Debug.Log("Son iguales");
        }
;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
