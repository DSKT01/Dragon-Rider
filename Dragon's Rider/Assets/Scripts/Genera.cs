using UnityEngine;
using System.Collections;

public class Genera : MonoBehaviour
{

    public Transform PuntoGenerador;
    private float EspacioEntre;

    // Use this for initialization
    void Start()
    {

        EspacioEntre = 2100;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < PuntoGenerador.position.x)
        {
            transform.position = new Vector3(transform.position.x + EspacioEntre, transform.position.y, transform.position.z);

        }
    }
}