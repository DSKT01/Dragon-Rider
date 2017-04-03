using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public GameObject Roberto;
    public GameObject Dragon;
    public float Velocidad;
    public float FSalto;
    public Rigidbody2D Cuerpo;
    public bool EnSuelo;
    public LayerMask QueEsSuelo;
    public Collider2D Colision;
    public float Speed;
    public float Jump;
    public Rigidbody2D Body;
    public float YMin;
    public float YMax;




    // Use this for initialization
    void Start () {
        
	}

    // Update is called once per frame
    void Update() {

        if (Roberto.activeInHierarchy)
        {
            EnSuelo = Physics2D.IsTouchingLayers(Colision, QueEsSuelo);

            Cuerpo.velocity = new Vector2(Velocidad, Cuerpo.velocity.y);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (EnSuelo)
                {
                    Cuerpo.velocity = new Vector2(Cuerpo.velocity.x, FSalto);
                }
            }
        }
        if (Dragon.activeInHierarchy)
        {
            Body.velocity = new Vector2(Speed, Body.velocity.y);
            if (Input.GetKey(KeyCode.Space))
            {
                Body.velocity = new Vector2(Body.velocity.x, Jump);
            }

            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, YMin, YMax), transform.position.z);
        }
       
	}
}
