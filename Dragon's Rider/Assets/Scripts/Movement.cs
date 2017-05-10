using UnityEngine;
using System.Collections;




public class Movement : MonoBehaviour
{
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
    public Puntuacion puntos;
    
    private float Save;
    private bool Abajo;
    private Animator Animar;
    private float W = 1.350f;
    public LayerMask Muerte;
    public bool Muere = false;
    private float save2;
    //public float Jump;
    //public Rigidbody2D Body;
    //public float YMin;
    //public float YMax;




    // Use this for initialization
    void Start()
    {
        Save = velocidad;
        save2 = FSalto;
        Animar = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (VEL.control > 0 && VEL.control <= VEL.TA + 1)
        {
            velocidad = 0;
            FSalto = 0;
        }
        else
        {
            velocidad = Save;
            FSalto = save2;
        }
        if (EnSuelo)
        {
            CS = 1;
        }
        velocidad += Time.deltaTime;
        Save += Time.deltaTime;
        if (Roberto.activeInHierarchy)
        {
            EnSuelo = Physics2D.IsTouchingLayers(Colision, QueEsSuelo);

            Cuerpo.velocity = new Vector2(velocidad, Cuerpo.velocity.y);
            if (Abajo == false)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    if (CS > 0)
                    {
                        Cuerpo.velocity = new Vector2(Cuerpo.velocity.x, FSalto);
                        CS--;
                    }
                }
            }

            if (Abajo == false)
            {
                W = 1.350f;
                if (Input.GetKeyDown(KeyCode.S))
                {
                    Abajo = true;

                }
            }
            if (Abajo == true)
            {
                W -= Time.deltaTime;
                if (W < 0)
                {
                    Abajo = false;
                }
            }


            Animar.SetFloat("velocidad", Cuerpo.velocity.x);
            Animar.SetBool("EnSuelo", EnSuelo);
            Animar.SetBool("Agacha", Abajo);
        }
        Muere = Physics2D.IsTouchingLayers(Colision, Muerte);

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



    
   
