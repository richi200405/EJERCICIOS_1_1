using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Personaje personaje1;
    private Personaje personaje2;
    private bool yaEjecutado = false;
    public static GameManager Instance;
    public Personaje player;
    public Personaje enemigo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !yaEjecutado)
        {
            PrepararPersonajes();
            yaEjecutado = true;
        }
    }

    void PrepararPersonajes()
    {
        personaje1 = new Personaje("Guerrero", 100f, 1500f);
        personaje2 = new Personaje("Mago", 80f, 2000f);

        Debug.Log(personaje1.Nombre + " tiene nivel: " + personaje1.CalcularNivel());
        Debug.Log(personaje2.Nombre + " tiene nivel: " + personaje2.CalcularNivel());
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void FinDeTurno(Personaje personaje)
    {
        if (personaje == player)
        {
            player.miTurno = false;
            enemigo.miTurno = true;
        }
        else
        {
            enemigo.miTurno = false;
            player.miTurno = true;
        }
    }
}