using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios3_6 : MonoBehaviour
{
    [SerializeField] int velocidad = 0;
    // Start is called before the first frame update
    void Start()
    {
        float conversion = velocidad / 3.6f;
        Debug.Log(conversion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
