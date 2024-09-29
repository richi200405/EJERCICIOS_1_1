using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{

    [SerializeField]
    private float danhoMinimo;

    [SerializeField]
    private float danhoMaximo;

    [SerializeField]
    private int capacidadTotal;

    [SerializeField]
    private bool esAutomatica;

    private int municionActual;
    
    // Start is called before the first frame update
    void Start()
    {
        municionActual = capacidadTotal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float ObtenerDanhoMinimo()
    {
        return danhoMinimo;
    }

    public float ObtenerDanhoMaximo()
    {
        return danhoMaximo;
    }

    public int ObtenerCapacidadTotal()
    {
        return capacidadTotal;
    }

    public bool EsAutomatica()
    {
        return esAutomatica;
    }

    public int ObtenerMunicionActual()
    {
        return municionActual;
    }

    public float Disparar()
    {
        if (municionActual > 0)
        {
            municionActual--;
            // Lógica de disparo aquí
            Debug.Log("Disparo realizado. Munición restante: " + municionActual);
            return 0;
        }
        else
        {
            Debug.Log("Sin munición.");
            return -1;
        }
    }

    // Método para recargar el arma
    public float Recargar()
    {
        if (municionActual < capacidadTotal)
        {
            municionActual = capacidadTotal;
            Debug.Log("Arma recargada. Munición actual: " + municionActual);
            return 0;
        }
        else
        {
            Debug.Log("Arma ya cargada.");
            return -1;
        }
    }
}
