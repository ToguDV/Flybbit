using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFase : MonoBehaviour
{
    public Text txtfase;
    public AudioSource audioSource;
    public AudioClip sonido;
    public Animator animator;
    public Animation animation;
    public int contador;

    // Start is called before the first frame update

    public void Actualizar()
    {

        animator.enabled = true;
        animator.Play("Parpadeo", 0);
        txtfase.text = "Fase: " + PlatformRandom.fase;
    }

    public void Sonar()
    {
        
        audioSource.clip = sonido;
        audioSource.Play(0);
        contador++;
        print(contador);
    }

    public void Verificar()
    {
        if (contador >= 3)
        {
            audioSource.clip = null;
            contador = 0;
            animator.enabled = false;
            print("pausado");
        }
    }
}
