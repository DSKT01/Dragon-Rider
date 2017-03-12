using UnityEngine;
using System.Collections;

public class Generar : MonoBehaviour
{
  
    
    public Transform PuntoControl;
    private float Espacio;
 
    // Use this for initialization
    void Start()
    {
        Espacio = 180;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < PuntoControl.position.x)
        {
            transform.position = new Vector3 (transform.position.x + Espacio, transform.position.y, transform.position.z);

        }
    }
}