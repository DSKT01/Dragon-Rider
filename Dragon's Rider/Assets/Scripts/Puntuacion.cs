using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {
    public float puntuacion = 0;
   
    public int puntos = 0;
    public Montarse Mon;
    public float aumento = 1;
    private float aumento2 = 10;
    public Movement muerte;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(muerte.Muere==false)
            {
            aumento += Time.deltaTime / 100;
            if (Mon.Points == false)
            {

                puntuacion += Time.deltaTime * (aumento / 2);
                puntos = (int)puntuacion;

            }
            else
            {

                puntuacion += Time.deltaTime * ((aumento * aumento2) / 2);
                puntos = (int)puntuacion;

            }

        }
    }

}
