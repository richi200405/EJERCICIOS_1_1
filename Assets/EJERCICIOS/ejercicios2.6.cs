using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int puntuacion1 = 5;
    int puntuacion2 = 7;
    int puntuacion3 = 4;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(puntuacion1);
        Debug.Log(puntuacion2);
        Debug.Log(puntuacion3);
        int media = (puntuacion1 + puntuacion2 + puntuacion3) / 3;
        Debug.Log(media);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
