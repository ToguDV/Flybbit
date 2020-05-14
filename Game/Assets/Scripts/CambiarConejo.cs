using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarConejo : MonoBehaviour
{
    public AccesoriosScriptable accesoriosScriptable;
    public static int ojos;
    public static int orejas;
    public static int cuello;
    public static int skin;
    public GameObject aOjos;
    public GameObject aOrejas;
    public GameObject aCuello;

    // Start is called before the first frame update
    void Start()
    {
        Inicio();
        Actualizar();
    }


    public void Actualizar()
    {
        aOjos.GetComponent<SpriteRenderer>().sprite = accesoriosScriptable.accesorios[ojos];
        aOrejas.GetComponent<SpriteRenderer>().sprite = accesoriosScriptable.accesorios[orejas];
        aCuello.GetComponent<SpriteRenderer>().sprite = accesoriosScriptable.accesorios[cuello];
        gameObject.GetComponent<SpriteRenderer>().sprite = accesoriosScriptable.accesorios[skin];
        PlayerPrefs.SetInt("ojos", ojos);
        PlayerPrefs.SetInt("orejas", orejas);
        PlayerPrefs.SetInt("cuello", cuello);
        PlayerPrefs.SetInt("skin", skin);
    }

    public void Inicio()
    {
        ojos = PlayerPrefs.GetInt("ojos", 0);
        orejas = PlayerPrefs.GetInt("orejas", 0);
        cuello = PlayerPrefs.GetInt("cuello", 0);
        skin = PlayerPrefs.GetInt("skin", 19);
    }
}
