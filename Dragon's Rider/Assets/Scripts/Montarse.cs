using UnityEngine;
using System.Collections;

public class Montarse : MonoBehaviour {
    public GameObject Roberto;
    public GameObject Dragon;
    public Collider2D  RobertoC;
    public Collider2D  DragonC;
    public LayerMask PowerUp;
    private bool Colision;
    private float segInc = 0;
    private float segFn = 3;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Colision = Physics2D.IsTouchingLayers(RobertoC, PowerUp);
        if (Colision)
        {
            Roberto.SetActive(false);
            Dragon.SetActive(true);
        }
        while (Dragon.activeInHierarchy)
        {
            segInc += Time.deltaTime;
            if (segInc >= segFn)
            {
                Roberto.SetActive(true);
                Dragon.SetActive(false);
            }
        }

    }
}
