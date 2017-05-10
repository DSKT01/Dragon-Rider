using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour {

    public Movement muerte;
    public GameObject menu;
    public GameObject arbol;
    public Text puntos;
    public Text mayor;
     

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (muerte.Muere == false)
        {
            menu.gameObject.SetActive(false);
            arbol.gameObject.SetActive(true);
            puntos.gameObject.SetActive(true);
            mayor.gameObject.SetActive(false);
        }
        else
        {
            menu.gameObject.SetActive(true);
            arbol.gameObject.SetActive(false);
            puntos.gameObject.SetActive(false);
            mayor.gameObject.SetActive(true);
        }
    }
}
