using UnityEngine;
using System.Collections;

public class Montarse : MonoBehaviour {


    public bool Montado = false;
    public float control = 0;
    public Collider2D Player;
    public Movement J;
    public LayerMask PowerUp;
    public bool Colision = false;
    public int TA;
    public Transform ED;
    public Transform EP;
    
    private int Cont2;
    public Transform PuntoDC;
    public float control2 = 10;
    
    private int Cont22;
    
    private float DisR = 0;
    
    private float Dis = 0;
    public bool Points = false;
    public Transform PA;
    public Transform PB;
   
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Colision = Physics2D.IsTouchingLayers(Player, PowerUp);
        if (Colision)
        {
            Montado = true;
        }
       
       


        if (Montado)
        {

            control += Time.deltaTime;
            Cont2 = (int)control;
            control2 = 0;




            if (Cont2 == TA)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, ED.position.z);
                PuntoDC.position = new Vector3(PA.position.x, PuntoDC.position.y, PuntoDC.position.z);
                Dis = 100;
                Points = true;
               

            }
            if (Cont2 > TA)
            {
                DisR += Time.deltaTime * 5;
                Dis -= DisR * Time.deltaTime;
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Dis += 10;
                }
            }
        }
        if (Montado == false)
        {
            DisR = 0;
            Dis = 0;
            control = 0;
            control2 += Time.deltaTime;
            Cont22 = (int)control2;
            if (Cont22 == TA)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, EP.position.z);
                PuntoDC.position = new Vector3(PB.position.x, PuntoDC.position.y, PuntoDC.position.z);
                Points = false;
                
            }
        }
        if (Dis < 0)
        {
            Montado = false;
        }




    }
}
