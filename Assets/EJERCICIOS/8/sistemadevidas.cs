using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sistemadevidas : MonoBehaviour
{
    [SerializeField]
    private float vidaInicial = 100f;

    private float vidaActual;

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaInicial;
    }

    
    public float RecibirCura(float cantidad)
    {
        if (cantidad < 0)
        {
            return -1f;
        }

        vidaActual += cantidad;
        return vidaActual;
    }

    public float RecibirDanho(float danho)
    {
        if (danho < 0)
        {
            return -1f;
        }

        vidaActual -= danho;
        if (vidaActual <= 0)
        {
            vidaActual = 0;
            return 0f;
        }

        return vidaActual;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
