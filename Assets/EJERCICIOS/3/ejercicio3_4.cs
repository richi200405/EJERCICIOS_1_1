using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3_4 : MonoBehaviour
{
    [SerializeField] int experiencia = 0;
    // Start is called before the first frame update
    void Start()
    {
       float LVL = 32 +  (9 * experiencia /5);   
        Debug.Log(LVL);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
