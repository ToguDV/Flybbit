using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Platform : MonoBehaviour
{
    public static float positiony = -4;
    public float positionx;
    public GameObject platformRandom;
    public float separacion = 3f;
    public static int score = 0;
    int intervaloInicial;
    public static int intervalo = 10;
    public static float tamanoMinimo = 0.5f;
    public bool encoger;
    bool touch;
    public bool posicionarx;
    public float posicionposterior;
    public GameObject camera;
    SpriteRenderer spriteRenderer;
    public Colores colorFases;
    public bool grande;
    public bool noColorear;
    
    int tamano;
    void Start()
    {
        iniciar();
        camera = GameObject.Find("camera");
        if (!noColorear)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.color = colorFases.color[PlatformRandom.fase - 1];

            tamano = GetComponentsInChildren<SpriteRenderer>().Length;
            SpriteRenderer[] spriteRenderers = new SpriteRenderer[tamano];
            spriteRenderers = GetComponentsInChildren<SpriteRenderer>();

            for (int i = 0; i < spriteRenderers.Length; i++)
            {

                spriteRenderers[i].color = colorFases.color[PlatformRandom.fase - 1];

            }
        }
        //}

    }

    // Update is called once per frame
    void Update()
    {
        if(score >= intervalo && encoger && tamanoMinimo >= 0.2f)
        {
            intervalo += intervaloInicial;
            tamanoMinimo -= 0.009f;
        }

        if ((gameObject.transform.position.y - camera.transform.position.y) <= -10.5f)
        {
            Destroy(gameObject);
        }



    }

    void OnCollisionEnter2D(Collision2D other)
    {
       
    }
    public void iniciar()
    {
        
        Position();
        PlayerPrefs.SetInt("carrots", money.carrots);
        if (encoger)
        {
            intervaloInicial = intervalo;
            transform.localScale = new Vector3(Random.Range(tamanoMinimo, tamanoMinimo*2), 0.07f, 1f);
        }

    }


    void Position()
    {
        
        
            positionx = Random.Range(-2f, 2f);
            positiony = Random.Range(positiony+separacion*0.1f, positiony + separacion);
        if (!posicionarx)
        {
            positionx = 0f;
        }


            transform.position = (new Vector3(positionx, positiony, 0));
            positiony = positiony + posicionposterior;
       
    }

   

    void OnBecameInvisible()
    {
       
    }

    // ...and enable it again when it becomes visible.
    void OnBecameVisible()
    {
        platformRandom = GameObject.Find("camera");
        if (!touch){
            platformRandom.SendMessage("InstantiatePlatform");
            touch = true;
            score++;
            if(score > PlayerPrefs.GetInt("record", 0))
            {
                PlayerPrefs.SetInt("record", score);
            }
        }

       
       
    }
}
