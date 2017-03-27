using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {
    public Transform Jugador;

    private bool SePuede = true;
    private int Puntos = -3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (SePuede)
        {
            if (transform.position.x < Jugador.position.x)
            {
                SePuede = false;
                Puntos += 3;
                if (Puntos >= 3)
                {
                    Debug.Log(Puntos);
                }
                
            }
        }
        if (transform.position.x > Jugador.position.x)
        {
            SePuede = true;
        }
	}
}
