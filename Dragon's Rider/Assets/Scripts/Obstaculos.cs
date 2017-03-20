using UnityEngine;
using System.Collections;

public class Obstaculos : MonoBehaviour {

    private int Desde = 0;
    public int Probabilidad;
    private int Tiempo;
    public GameObject Obstacle;
    public Transform PuntoGenerador;
    private bool SePuede = false;
   
    private bool Condicion = true;
    


    // Use this for initialization
    void Start () {

        Tiempo = 1;
       
    }
	
	// Update is called once per frame
	void Update () {

        
        if (Tiempo == 1)
        {
            SePuede = true;
        }
       
            
        if (SePuede)
        {
          
            
            SePuede = false;
            Instantiate(Obstacle, PuntoGenerador.position, PuntoGenerador.rotation);


        }
        
        Tiempo = Aleatorio(Desde, Probabilidad);
        


    }

    private int Aleatorio (int des, int has)
    {

        int final = 0;
        if (has >= des)
        {
            final = Random.Range(des, has);
        }
        return final;
     
    }

    
}
