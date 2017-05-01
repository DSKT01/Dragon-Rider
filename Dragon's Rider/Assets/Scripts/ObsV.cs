using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsV : MonoBehaviour {
    public Rigidbody2D Cuerpo;
    public float velocidad;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Cuerpo.velocity = new Vector2(-velocidad, Cuerpo.velocity.y);
    }
}
