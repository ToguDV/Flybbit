using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BtnCerrarCompra : MonoBehaviour
{
    public GameObject cuadroCompra;
    public static bool isComprando;
    // Start is called before the first frame update
   

    // Update is called once per frame
    public void OnMouseDown()
    {
        isComprando = false;
        cuadroCompra.SetActive(false);
    }
}
