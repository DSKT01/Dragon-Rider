using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

    public Movement Jugador;
    private Vector3 UltimaPosicion;
    private float AMover;


    // Use this for initialization
    void Start()
    {
        Jugador = FindObjectOfType<Movement>();
        UltimaPosicion = Jugador.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        AMover = Jugador.transform.position.x - UltimaPosicion.x;
        transform.position = new Vector3(transform.position.x + AMover, transform.position.y, transform.position.z);


        UltimaPosicion = Jugador.transform.position;
    }
}
