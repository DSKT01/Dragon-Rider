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
    [SerializeField]
    private int Cont2;
    public Transform PuntoDC;
    public float control2 = 10;
    [SerializeField]
    private int Cont22;


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
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10);
                PuntoDC.position = new Vector3(PuntoDC.position.x + 40, PuntoDC.position.y, PuntoDC.position.z);

            }
        }
        if (Montado == false)
        {
            control = 0;
            control2 += Time.deltaTime;
            Cont22 = (int)control2;
            if (Cont22 == TA)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 10);
                PuntoDC.position = new Vector3(PuntoDC.position.x -40, PuntoDC.position.y, PuntoDC.position.z);

            }
        }

    }
}
