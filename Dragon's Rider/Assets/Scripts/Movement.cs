using UnityEngine;
using System.Collections;




public class Movement : MonoBehaviour {
    public GameObject Roberto;
    //public GameObject Dragon;
    public float velocidad;
    public float FSalto;
    public Rigidbody2D Cuerpo;
    public bool EnSuelo;
    public LayerMask QueEsSuelo;
    public Collider2D Colision;
    private int CS = 1;
    public Montarse VEL;
    [SerializeField]
    private float Save;
    
    
   //public float Jump;
    //public Rigidbody2D Body;
    //public float YMin;
    //public float YMax;




    // Use this for initialization
    void Start () {
        Save = velocidad;
	}

    // Update is called once per frame
    void Update() {

        if (VEL.control > 0 && VEL.control < VEL.TA )
        {
            velocidad = 0;
        }
        else
        {
            velocidad = Save;
        }
        if (EnSuelo)
        {
            CS = 1;
        }
        velocidad += Time.deltaTime ;
        Save += Time.deltaTime;
        if (Roberto.activeInHierarchy)
        {
            EnSuelo = Physics2D.IsTouchingLayers(Colision, QueEsSuelo);

            Cuerpo.velocity = new Vector2(velocidad, Cuerpo.velocity.y);
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (CS > 0)
                {
                    Cuerpo.velocity = new Vector2(Cuerpo.velocity.x, FSalto);
                    CS--;
                }
            }
        }
        /*if (Dragon.activeInHierarchy)
        {
            Body.velocity = new Vector2(velocidad, Body.velocity.y);
            if (Input.GetKey(KeyCode.Space))
            {
                Body.velocity = new Vector2(Body.velocity.x, Jump);
            }

            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, YMin, YMax), transform.position.z);
        }*/

       
	}
}
