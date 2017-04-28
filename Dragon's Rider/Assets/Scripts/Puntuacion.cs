using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {
    private float puntuacion = 0;
    private int puntos = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        puntuacion += Time.deltaTime / 2;
        puntos = (int)puntuacion;
        Debug.Log(puntos);
	}
}
