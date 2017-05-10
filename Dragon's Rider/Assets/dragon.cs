using UnityEngine;
using System.Collections;

public class dragon : MonoBehaviour {
    public Montarse sino;
    private float tiempo;
    private float tiempo2;
    private float control;
    private bool listo;
    private Animator Animar;
    private float control2;
    private bool Montado2;

	// Use this for initialization
	void Start () {
        Animar = GetComponent<Animator>();
        control = 1.1f;
        control2 = 0.52f;
    }
	
	// Update is called once per frame
	void Update () {
       
        if (sino.Montado == true)
        {
            tiempo += Time.deltaTime;
        }       
        if (tiempo > control)
        {
            listo = true;
        }

        if (sino.Montado == false)
        {
            tiempo2 += Time.deltaTime;
        }
        if (tiempo2 > control2)
        {
            listo = false;
        }
        Animar.SetBool("montado2", sino.Montado);
        Animar.SetBool("listo", listo);
       

    }
}
