using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menú : MonoBehaviour {

    public string juego;
    public string creditos;
    public string menu;
 

    public void Jugar()
    {
        Application.LoadLevel(juego);
    }
    public void Opciones ()
    {
        Application.LoadLevel(creditos);
    }
    public void Volver ()
    {
        Application.LoadLevel(menu);
    }
    public void Salir ()
    {
        Application.Quit();

    }
     
   

}

