﻿using UnityEngine;
using System.Collections;

public class Obstaculo : MonoBehaviour {
    public Transform PuntoFinal;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < PuntoFinal.position.x)
        {
            Destroy(gameObject, 0);

        }
    }
}
