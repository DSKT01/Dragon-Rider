﻿using UnityEngine;
using System.Collections;

public class Obstaculos : MonoBehaviour {

    private int Desde = 1;
    public float Probabilidad;
    private int Tiempo;
    public GameObject Obstacle;
    public Transform PuntoGenerador;
    private bool SePuede = false;
    private int prob;
    private float segInc = 0;
    private float segFn = 1;
    private bool condicion2 = false;
   
 
    


    // Use this for initialization
    void Start () {

        Tiempo = 0;
        
       
    }
	
	// Update is called once per frame
	void Update () {

        //Debug.Log(Tiempo);
        prob = (int)Probabilidad;
        Tiempo = Random.Range(Desde, prob);
        segInc += Time.deltaTime;
        if (!(Probabilidad <= 1))
        {
            Probabilidad -= Time.deltaTime;
        }
        else
        {
            Probabilidad = 1;
        }

        if (Tiempo == 1)
        {
            SePuede = true;
        }
        if (segInc >= segFn)
        {
            condicion2 = true;
        }



        if (SePuede)
        {

            if (condicion2)
            {

                
                Instantiate(Obstacle, PuntoGenerador.position, PuntoGenerador.rotation);
                SePuede = false;
                segInc = 0;
                condicion2 = false;

            }
        }
    }
}
