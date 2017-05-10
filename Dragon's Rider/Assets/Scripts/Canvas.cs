using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour {

    public Movement muerte;
    public GameObject menu;
    public GameObject arbol;
    public Text puntos;
    public Text mayor;
    public Puntuacion puntaje;
    public Montarse montado;
    public GameObject cosa;
    [SerializeField]
    private int Mpuntos;

    // Use this for initialization
    void Start()
    {
        Mpuntos = PlayerPrefs.GetInt("+puntos");

    }

    // Update is called once per frame
    void Update()
    {
        if (montado. Montado )
        {
            cosa.gameObject.SetActive(true);
        }

        if (muerte.Muere == false)
        {
            menu.gameObject.SetActive(false);
            arbol.gameObject.SetActive(true);
            puntos.gameObject.SetActive(true);
            

        }
        else
        {
            menu.gameObject.SetActive(true);
            arbol.gameObject.SetActive(false);
            puntos.gameObject.SetActive(false);
            
        }
        if (puntaje.puntos > Mpuntos)
        {
            Mpuntos = puntaje.puntos;
            PlayerPrefs.SetInt("+puntos", Mpuntos);
        }

        puntos.text = "Puntos: " + puntaje.puntos;
        mayor.text = "+Puntos: " + Mpuntos;
    }
}
