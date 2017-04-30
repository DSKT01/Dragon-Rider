using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {
    private float puntuacion = 0;
    private int puntos = 0;
    [SerializeField]
    private float aumento = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        aumento += Time.deltaTime / 100;
        puntuacion += Time.deltaTime * (aumento/2);
        puntos = (int)puntuacion;
        Debug.Log(puntos);
	}
}
