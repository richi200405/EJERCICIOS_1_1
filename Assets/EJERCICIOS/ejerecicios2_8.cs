using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerecicios2_8 : MonoBehaviour
{
    int vida = 120;
  

    // Start is called before the first frame update
    void Start()
    {
        int turno1 = 3 * vida / 100;
        int vida1 = vida - turno1;
        Debug.Log(vida1);
        
        int turno2 = 6 * vida / 100;
        int vida2 = vida1 - turno2;
        Debug.Log(vida2);
        
        int turno3 = 9 * vida / 100;
        int vida3 = vida2 - turno3;
        Debug.Log(vida3);

        int turno4 = 12 * vida / 100;
        int vida4 = vida3 - turno4;
        Debug.Log(vida4);
        
        int turno5 = 15* vida / 100;
        int vida5 = vida4 - turno5;
        Debug.Log(vida5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
