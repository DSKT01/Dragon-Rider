using UnityEngine;
using System.Collections;

public class animacion : MonoBehaviour {

    private Animator Animar;
    public Montarse montar;


	// Use this for initialization
	void Start () {
        Animar = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        
        Animar.SetBool("Nace", montar.Montado);
    }
}
