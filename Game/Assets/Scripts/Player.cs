using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public bool salto = false;
    public bool salto2 = false;
    Rigidbody2D rigidbody2D;
    public float jumpForce = 10f;
    public float movementForce = 5f;
    public float maxSpeed = 6f;
    public static bool followPLayer;
    public BoxCollider2D boxCollider2D;
    public float speed = 100f;
    public GameObject camera;
    SpriteRenderer spriteRenderer;
    float velocidadAnterior;
    bool despausado;
    bool muerto;
    float tiempo;
    public static bool saltarExterno;

    public GameObject particulaSalto;
    public GameObject particulaMuerte;
    public Transform transParticula;

    public AudioSource audioSource;
    public AudioClip clipSalto;
    public AudioClip clipZanahoria;
    public AudioClip clipMuerte;
    public bool vientoDerecho;
    public float velocidadViento;
    public int modo = 0;
    // Start is called before the first frame update
    void Start()
    {
        muerto = false;
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        

        //HACKS
        if (Input.GetKeyDown(KeyCode.F))
        {
            Platform.score += 20;
        }

        if (muerto)
        {
            tiempo += Time.deltaTime;
            if (tiempo >= 2f)
            {
                rigidbody2D.gravityScale = 0f;
                rigidbody2D.velocity = new Vector2(0f, 0f);
                if (modo == 0)
                {
                    SceneManager.LoadScene("game");
                }
                else if(modo == 1)
                {
                    SceneManager.LoadScene("CrazyMode");
                }
                else
                {
                    SceneManager.LoadScene("game");
                }
            }
        }
        if(rigidbody2D.velocity.y <=0)
        {
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
            boxCollider2D.enabled = true;
        }

        else
        {
            boxCollider2D.enabled = false;
            spriteRenderer.color = new Color(1f, 1f, 1f, 0.7f);
        }

        if((gameObject.transform.position.y - camera.transform.position.y) <= -5.5f)
        {
            if (modo == 0)
            {
                SceneManager.LoadScene("game");
            }
            else if (modo == 1)
            {
                SceneManager.LoadScene("CrazyMode");
            }
            else
            {
                SceneManager.LoadScene("game");
            }
        }
        
        
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if (CerrarPausa.abierto == false && !muerto)
        {
            rigidbody2D.isKinematic = false;
            rigidbody2D.gravityScale = 1f;

            if (despausado)
            {
                rigidbody2D.velocity = new Vector2(0f, velocidadAnterior);
                despausado = false;
            }


            //MOVIMIENTO GIROSCOPIO
            if (!muerto)
            {
                transform.Translate(new Vector3(Input.acceleration.x * speed, 0f, 0f));
                if (vientoDerecho)
                {
                    transform.Translate(new Vector3(0.2f * velocidadViento, 0f, 0f));
                }
            }

            
        }
        else
        {
            
            if(!despausado)
            {
                velocidadAnterior = rigidbody2D.velocity.y;
                despausado = true;
            }
            
            rigidbody2D.isKinematic = true;
            rigidbody2D.gravityScale = 0f;
            
            rigidbody2D.velocity = new Vector2(0f, 0f);
            
            
        }
        

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.AddForce(new Vector2(movementForce, 0f));
        }

        if (Input.GetKey(KeyCode.A))
        {
            
            rigidbody2D.AddForce(new Vector2(-movementForce, 0f));
        }

        if(rigidbody2D.velocity.x > maxSpeed)
        {
            rigidbody2D.velocity = new Vector2(maxSpeed, rigidbody2D.velocity.y);
        }

        if(rigidbody2D.velocity.x < -maxSpeed)
        {
            rigidbody2D.velocity = new Vector2(-maxSpeed, rigidbody2D.velocity.y);
        }

        if (saltarExterno)
        {
            followPLayer = true;
            rigidbody2D.velocity = new Vector2(0f, 0f);

            salto = true;
            salto2 = true;
            saltarExterno = false;
        }

        

        if (salto)
        {

            
            Instantiate(particulaSalto, transParticula.position, transParticula.rotation , null);
            if(salto2)
            {
                jumpForce *= 2;
                audioSource.clip = clipZanahoria;
                audioSource.Play();
            }

            else
            {
                audioSource.clip = clipSalto;
                audioSource.Play();
            }
            rigidbody2D.velocity = new Vector2(0f, jumpForce);
            salto = false;
            if (salto2)
            {
                jumpForce /= 2;
                salto2 = false;
            }
        }


    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "puntoDebil")
        {
            followPLayer = true;
            rigidbody2D.velocity = new Vector2(0f, 0f);

            salto = true;
            vientoDerecho = false;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "ground")
        {
            followPLayer = true;
            rigidbody2D.velocity = new Vector2(0f,0f);
            
            salto = true;
        }

        if (other.gameObject.tag == "muerte")
        {
            Morir(); 
        }


    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            salto = false;
            followPLayer = false;
        }


    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "carrot")
        {
            money.carrots++;
           
            Destroy(col.gameObject);
            salto = true;
            salto2 = true;
        }
    }

    public void Morir()
    {
        if (!muerto)
        {
            spriteRenderer.enabled = false;
            Instantiate(particulaMuerte, transParticula.position, transParticula.rotation, null);
            audioSource.clip = clipMuerte;
            audioSource.Play();
        }
        muerto = true;
        
    }

}
