using UnityEngine;
using System.Collections;

public class Genera : MonoBehaviour {
    public GameObject Plataforma;
    public Transform PuntoGenerador;
    public float EspacioEntre;
    private float Tamano;
    // Use this for initialization
    void Start () {
        Tamano = Plataforma.GetComponent<BoxCollider2D>().size.x;

	}
	
	// Update is called once per frame
	void Update () {
	if(transform.position.x < PuntoGenerador.position.x)
        {
            transform.position = new Vector3(transform.position.x + Tamano + EspacioEntre, transform.position.y, transform.position.z);
            Instantiate (Plataforma, transform.position, transform.rotation);
        }
	}
}
