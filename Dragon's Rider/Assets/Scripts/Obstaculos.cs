using UnityEngine;
using System.Collections;

public class Obstaculos : MonoBehaviour {

    private int Desde = 1;
    public int Probabilidad;
    private int Tiempo;
    public GameObject Obstacle;
    public Transform PuntoGenerador;
    private bool SePuede = false;
    
    
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
        Tiempo = Random.Range(Desde, Probabilidad);
        segInc += Time.deltaTime;

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
