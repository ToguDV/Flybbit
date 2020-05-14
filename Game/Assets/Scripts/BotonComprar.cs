using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonComprar : MonoBehaviour
{
    public static int precio;
    public static int id;
    public Text titulo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        if(money.carrots >= precio)
        {
            money.carrots -= precio;
            PlayerPrefs.SetInt("carrots", money.carrots );
            titulo.text = "Lo has comprado";
            PlayerPrefs.SetInt("comprado"+id, 1);
            gameObject.SetActive(false);
        }

        else
        {
            titulo.text = "No tienes zanahorias suficientes";
        }
       
    }
}
