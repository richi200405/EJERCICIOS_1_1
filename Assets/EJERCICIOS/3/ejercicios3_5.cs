using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios3_5 : MonoBehaviour
{
    [SerializeField] float radio = 0;
    // Start is called before the first frame update
    void Start()
    {
        float longitud;
        longitud = 2*3.14f*radio ;
        Debug.Log(longitud);
        float area = 3.14f*(radio*radio);
        Debug.Log(area);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
