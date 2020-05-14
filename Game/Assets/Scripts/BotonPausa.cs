using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPausa : MonoBehaviour
{
    public GameObject cuadroPausa;
    // Start is called before the first frame update
    void Start()
    {
        CerrarPausa.abierto = false;
        Actualizar();   
    }

    // Update is called once per frame
   
    public void OnMouseDown()
    {
        CerrarPausa.abierto = true;
        Actualizar();
    }

    public void Actualizar()
    {
        
        if (CerrarPausa.abierto)
        {
            cuadroPausa.SetActive(true);
        }

        else
        {
            cuadroPausa.SetActive(false);
        }
    }
}
