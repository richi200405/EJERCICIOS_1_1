using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejericio5_8 : MonoBehaviour
{
    [SerializeField] int NUMERO = 1;
    [SerializeField] int NUMERO2 = 5;
    [SerializeField] int NUMERO3 = 6;
    // Start is called before the first frame update
    void Start()
    {
       if (NUMERO < 24 && NUMERO >= 0 && NUMERO2 < 60 && NUMERO2 >= 0 && NUMERO3 < 60 && NUMERO3 >= 0  ) 
        {
            Debug.Log("Funciona");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
