using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menú : MonoBehaviour {

    public string Escena1;
    public string Escena2;
    public string Escena;
    public Movement Muere;
    public string Escena3;

    public void Jugar()
    {
        Application.LoadLevel(Escena1);
    }
    public void Opciones ()
    {
        Application.LoadLevel(Escena2);
    }
    public void Volver ()
    {
        Application.LoadLevel(Escena);
    }
    public void Salir ()
    {
        Application.Quit();

    }
     
    public void Muerto()
    {
        if (Muere.Muere)
        {
            Application.LoadLevel(Escena3);
        }
    }

}

