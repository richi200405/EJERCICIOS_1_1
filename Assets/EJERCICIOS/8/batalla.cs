using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batalla : MonoBehaviour
{

    public Personaje player1 ;
    public Personaje player2 ;
    public Personaje player3 ;
    public Personaje player4 ;
    public Personaje combatiente1;
    public Personaje combatiente2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void GenerarCombatientes()
    {
        player1.RellenarStats(Random.Range(50, 121), Random.Range(20, 101), Random.Range(50, 201));
        player2.RellenarStats(Random.Range(50, 121), Random.Range(20, 101), Random.Range(50, 201));
        player3.RellenarStats(Random.Range(50, 121), Random.Range(20, 101), Random.Range(50, 201));
        player4.RellenarStats(Random.Range(50, 121), Random.Range(20, 101), Random.Range(50, 201));
    }

    public void CrearEmparejamiento()
    {
        List<Personaje> personajes = new List<Personaje> { player1, player2, player3, player4 };
        combatiente1 = personajes[Random.Range(0, personajes.Count)];
        personajes.Remove(combatiente1);
        combatiente2 = personajes[Random.Range(0, personajes.Count)];
    }

    public void GenerarCombate()
    {
        Debug.Log($"Combate entre {combatiente1} y {combatiente2}");

        Personaje primero, segundo;
        if (combatiente1.velocidad > combatiente2.velocidad)
        {
            primero = combatiente1;
            segundo = combatiente2;
        }
        else
        {
            primero = combatiente2;
            segundo = combatiente1;
        }

        while (combatiente1.vida > 0 && combatiente2.vida > 0)
        {
            primero.Atacar();
            if (segundo.vida > 0)
            {
                segundo.Atacar();
            }
        }

        if (combatiente1.vida <= 0)
        {
            Debug.Log($"{combatiente1} ha sido derrotado.");
        }
        if (combatiente2.vida <= 0)
        {
            Debug.Log($"{combatiente2} ha sido derrotado.");
        }
    }
}
