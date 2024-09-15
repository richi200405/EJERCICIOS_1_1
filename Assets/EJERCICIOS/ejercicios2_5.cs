using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios2_5 : MonoBehaviour
{
    int vidasPlayer1 = 5;
    int vidasPlayer2 = 5;
    int vidasPlayer3 = 5;
    int vidasPlayer4 = 5;


    // Start is called before the first frame update
    void Start()
    {
        int tomavidas1 = vidasPlayer2 + vidasPlayer3;
        int tomavidas2 = vidasPlayer3 + vidasPlayer1;
        int tomavidas3 = vidasPlayer1 + vidasPlayer4;
        int tomavidas4 = vidasPlayer4 + vidasPlayer2;
        
        Debug.Log(tomavidas1);
        Debug.Log(tomavidas2);
        Debug.Log(tomavidas3);
        Debug.Log(tomavidas4);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
