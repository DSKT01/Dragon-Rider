using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePowerup : MonoBehaviour {



    public Collider2D J;
    public Transform PuntoFinal;
   
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        
       


        if (transform.position.x < PuntoFinal.position.x)
        {
            Destroy(this.gameObject, 0);



        }
    }
   
}
