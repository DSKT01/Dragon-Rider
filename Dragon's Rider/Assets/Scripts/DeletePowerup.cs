using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePowerup : MonoBehaviour {
    public Montarse mon;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (mon.Montado == true)
        {
            Destroy(this.gameObject, 0);
        }
	}
}
