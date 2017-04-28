using UnityEngine;
using System.Collections;

public class Montarse : MonoBehaviour {


    public bool Montado = false;



    
    public Collider2D  powerup;
    public LayerMask PowerUp;
    public bool Colision = false;
   
   
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Colision = Physics2D.IsTouchingLayers(powerup, PowerUp);
        if (Colision)
        {
            Montado = true;
        }
        

    }
}
