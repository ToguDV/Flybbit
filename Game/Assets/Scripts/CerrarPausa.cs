using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarPausa : MonoBehaviour
{
    public static bool abierto;
    public GameObject cuadroPausa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   

    public void OnMouseDown()
    {
        abierto = false;
        BotonPausa botonPausa = new BotonPausa();
        botonPausa.cuadroPausa = cuadroPausa;
        botonPausa.Actualizar();
    }
}
