using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColearUI : MonoBehaviour
{
    public Text[] textos;
    public Colores colores;
    // Start is called before the first frame update
    void Start()
    {
        
     
        Actualizar();

    }

 

    public void Actualizar()
    {
        for (int i = 0; i < textos.Length; i++) {
            textos[i].color = colores.color[PlatformRandom.fase-1];
        }
    }
}
