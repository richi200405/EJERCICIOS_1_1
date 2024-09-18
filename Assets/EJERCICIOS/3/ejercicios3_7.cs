using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios3_7 : MonoBehaviour
{
    [SerializeField]float Basse = 0;
    [SerializeField] float Altura = 0;

    // Start is called before the first frame update
    void Start()
    {
        float areass = (Basse * Altura) /2;
        Debug.Log(areass);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
