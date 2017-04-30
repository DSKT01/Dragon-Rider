using UnityEngine;
using System.Collections;

public class Montarse : MonoBehaviour {


    public bool Montado = false;

    private float control = 0;

    
    public Collider2D  Player;
    public LayerMask PowerUp;
    public bool Colision = false;
    public int TA;
   
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Colision = Physics2D.IsTouchingLayers(Player, PowerUp);
        if (Colision)
        {
            Montado = true;
        }
        
        if (Montado)
        {
            control += Time.deltaTime;
            if (control > TA)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10);
            }
        }
        if (Montado == false)
        {
            control = 0;
        }

    }
}
