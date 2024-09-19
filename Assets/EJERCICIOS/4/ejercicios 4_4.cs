using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios4_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(converter(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float converter (float velocidad)
    {
        float conversion = velocidad / 3.6f;
        return conversion;
    }
}
