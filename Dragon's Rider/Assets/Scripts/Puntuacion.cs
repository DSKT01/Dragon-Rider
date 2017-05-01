using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {
    private float puntuacion = 0;
    private int puntos = 0;
    public Montarse Mon;
    private float aumento = 1;
    private float aumento2 = 10;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Mon.Points == false)
        {
            aumento += Time.deltaTime / 100;
            puntuacion += Time.deltaTime * (aumento / 2);
            puntos = (int)puntuacion;
            Debug.Log(puntos);
        }
        else
        {

            puntuacion += Time.deltaTime * ((aumento * aumento2) / 2);
            puntos = (int)puntuacion;
            Debug.Log(puntos);
        }

    }
    

}
