using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float Velocidad;
    public float FSalto;
    private Rigidbody2D Cuerpo;

    public bool EnSuelo;
    public LayerMask QueEsSuelo;
    private Collider2D Colision;




	// Use this for initialization
	void Start () {
        Cuerpo = GetComponent<Rigidbody2D>();
        Colision = GetComponent<Collider2D>();
	}

    // Update is called once per frame
    void Update() {

        EnSuelo = Physics2D.IsTouchingLayers(Colision, QueEsSuelo);

        Cuerpo.velocity = new Vector2(Velocidad, Cuerpo.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if  (EnSuelo)
            {
                Cuerpo.velocity = new Vector2(Cuerpo.velocity.x, FSalto);
            }
        }
        
	}
}
