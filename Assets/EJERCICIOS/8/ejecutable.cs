using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejecutable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        batalla batalla = new batalla();
        batalla.GenerarCombatientes();
        batalla.CrearEmparejamiento();
        batalla.GenerarCombate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
