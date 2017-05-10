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
        control = 5.01f;
        
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
            tiempo = 0;
        }

        

        Animar.SetBool("montado", listo);
        
       
    }
}
