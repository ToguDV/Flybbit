using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SeleccionAccesorio : MonoBehaviour
{
    public int precio;
    public bool ojos;
    public bool orejas;
    public bool cuello;
    public bool skin;
    public int id;
    public CambiarConejo cambiadorConejo;
    public GameObject quitar;
    public GameObject ventanaComprar;
    public GameObject cuadroComprar;
    public Text titulo;


    private void Update()
    {
        if(CambiarConejo.ojos != id && ojos)
        {
            Desrepetir();
        }

        if (CambiarConejo.orejas != id && orejas)
        {
            Desrepetir();
        }

        if (CambiarConejo.cuello != id && cuello)
        {
            Desrepetir();
        }

        if (CambiarConejo.skin != id && skin)
        {
            Desrepetir();
        }

    }

    void Start()
    {
        

        if (!BtnCerrarCompra.isComprando)
        {
            if (CambiarConejo.ojos != id)
            {

                quitar.SetActive(false);
            }

            else
            {

                quitar.SetActive(true);
            }

            if (CambiarConejo.orejas != id)
            {

                quitar.SetActive(false);
            }

            else
            {

                quitar.SetActive(true);
            }

            if (CambiarConejo.cuello != id)
            {

                quitar.SetActive(false);
            }

            else
            {

                quitar.SetActive(true);
            }

            if (CambiarConejo.skin != id)
            {

                quitar.SetActive(false);
            }

            else
            {

                quitar.SetActive(true);
            }
        }


    }



    // Update is called once per frame
    void OnMouseDown()
    {
        cuadroComprar.SetActive(true);
        if (!BtnCerrarCompra.isComprando)
        {
            BotonComprar.id = id;
            //Si el item son para ojos y le doy click
            if (ojos)
            {
                //si no está equipado y está comprado
                if (CambiarConejo.ojos != id && PlayerPrefs.GetInt("comprado" + id, 0) == 1)
                {
                    CambiarConejo.ojos = id;
                    cambiadorConejo.Actualizar();
                    quitar.SetActive(true);
                }

                //Si no está comprado
                else if (PlayerPrefs.GetInt("comprado" + id, 0) == 0)
                {
                    Comprar();
                }

                else
                {
                    CambiarConejo.ojos = 0;
                    cambiadorConejo.Actualizar();
                    quitar.SetActive(false);
                }
            }
            if (orejas)
            {
                if (CambiarConejo.orejas != id && PlayerPrefs.GetInt("comprado" + id, 0) == 1)
                {
                    CambiarConejo.orejas = id;
                    cambiadorConejo.Actualizar();
                    quitar.SetActive(true);
                }

                else if (PlayerPrefs.GetInt("comprado" + id, 0) == 0)
                {
                    Comprar();
                }

                else
                {
                    CambiarConejo.orejas = 0;
                    cambiadorConejo.Actualizar();
                    quitar.SetActive(false);
                }
            }

            if (cuello)
            {
                if (CambiarConejo.cuello != id && PlayerPrefs.GetInt("comprado" + id, 0) == 1)
                {
                    CambiarConejo.cuello = id;
                    cambiadorConejo.Actualizar();
                    quitar.SetActive(true);
                }

                else if (PlayerPrefs.GetInt("comprado" + id, 0) == 0)
                {
                    Comprar();
                }

                else
                {
                    CambiarConejo.cuello = 0;
                    cambiadorConejo.Actualizar();
                    quitar.SetActive(false);
                }
            }

            if (skin)
            {
                if (CambiarConejo.skin != id && PlayerPrefs.GetInt("comprado" + id, 0) == 1)
                {
                    CambiarConejo.skin = id;
                    cambiadorConejo.Actualizar();
                    quitar.SetActive(true);
                }

                else if (PlayerPrefs.GetInt("comprado" + id, 0) == 0)
                {
                    Comprar();
                }

                else
                {
                    print("desequipar");
                    CambiarConejo.skin = 19;
                    cambiadorConejo.Actualizar();
                    quitar.SetActive(false);
                }
            }



        }
    }

    void Comprar()
    {
        titulo.text = "¿Desea comprar por "+precio+"?";
        BtnCerrarCompra.isComprando = true;
        BotonComprar.precio = precio;
        ventanaComprar.SetActive(true);
    }

    void Desrepetir()
    {
        quitar.SetActive(false);
    }
}
