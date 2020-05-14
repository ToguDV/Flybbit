using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRandom : MonoBehaviour
{
    public GameObject[] plataforms;
    public static int random;
    public static bool anteriorMalo;
    public static int fase;
    public ShowFase showfase;
    bool primeraVez = false;
    bool primeraVez2 = false;
    public ColearUI colearUI;
    // Start is called before the first frame update
    private void Awake()
    {
        fase = 1;
    }

    void Start()
    {
        Platform.score = 0;
        Platform.positiony = -3f;
       
       
        InstantiatePlatform();



        Platform.intervalo = 50;
        Platform.tamanoMinimo = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public  void PrimeraVez()
    {
        if (!primeraVez)
        {
            primeraVez2 = false;
            showfase.Actualizar();

        }
        primeraVez = true;
    }

    public void PrimeraVez2()
    {
        if (!primeraVez2)
        {
            primeraVez = false;
            showfase.Actualizar();

        }
        primeraVez2 = true;
    }

   public void InstantiatePlatform()
    {
        colearUI.Actualizar();
        if (Platform.score <= 100)
        {
            InstFase1();
            fase = 1;

            
        }

        else if(Platform.score <= 200)
        {
            InstFase2();
            fase = 2;
            PrimeraVez2();
        }

        else if (Platform.score <= 300)
        {
            InstFase3();
            fase = 3;
            PrimeraVez();
        }
        else if (Platform.score <= 400)
        {
            InstFase4();
            fase = 4;
            PrimeraVez2();
        }
        else if (Platform.score <= 500)
        {
            InstFase5();

            fase = 5;
            PrimeraVez();
        }
        else if (Platform.score <= 600)
        {
            InstFase6();
            fase = 6;
            PrimeraVez2();
        }
        else if (Platform.score <= 700)
        {
            InstFase7();
            fase = 7;
            PrimeraVez();
        }
        else if (Platform.score <= 800)
        {
            InstFase8();
            fase = 8;
            PrimeraVez2();
        }

        else if (Platform.score <= 900)
        {
            InstFase8();
            fase = 8;
            PrimeraVez();
        }


    }

    //Fase 1 hasta 50 puntos)
    public void InstFase1()
    {
        
        Instantiate(plataforms[0]);
        
    }

    public void InstFase2()
    {
        random = Random.Range(1, 101);
        if (random <= 30)
        {
            controlMalos(1);
        }
        else
        {
            anteriorMalo = false;
            Instantiate(plataforms[0]);
        }
    }
    public void InstFase3()
    {
        random = Random.Range(1, 101);
        if (random <= 30)
        {
            controlMalos(1);
        }
        else if (random <= 35)
        {
            anteriorMalo = false;
            Instantiate(plataforms[2]);
        }
       
        else
        {
            anteriorMalo = false;
            Instantiate(plataforms[0]);
        }
    }

    public void InstFase4()
    {
        random = Random.Range(1, 101);
        if (random <= 5)
        {
            controlMalos(2);
        }
        else if (random <= 10)
        {
            anteriorMalo = false;
            Instantiate(plataforms[2]);
        }
        else if (random <= 30)
        {
            anteriorMalo = false;
            Instantiate(plataforms[3]);
        }
        else if (random <= 50)
        {
            anteriorMalo = false;
            Instantiate(plataforms[4]);
        }
        
        else
        {
            anteriorMalo = false;
            Instantiate(plataforms[0]);
        }
    }

    public void InstFase5()
    {
        random = Random.Range(1, 101);
        if (random <= 3)
        {
            controlMalos(1);
        }
        else if (random <= 8)
        {
            anteriorMalo = false;
            Instantiate(plataforms[2]);
        }
        else if (random <= 18)
        {
            anteriorMalo = false;
            Instantiate(plataforms[3]);
        }
        else if (random <= 28)
        {
            anteriorMalo = false;
            Instantiate(plataforms[4]);
        }
        else if (random <= 38)
        {
            controlMalos(5);
        }
        
        else
        {
            anteriorMalo = false;
            Instantiate(plataforms[0]);
        }
    }

    public void InstFase6()
    {
        random = Random.Range(1, 101);
        if (random <= 5)
        {
            controlMalos(1);
        }
        else if (random <= 10)
        {
            anteriorMalo = false;
            Instantiate(plataforms[2]);
        }
        else if (random <= 15)
        {
            anteriorMalo = false;
            Instantiate(plataforms[3]);
        }
        else if (random <= 20)
        {
            anteriorMalo = false;
            Instantiate(plataforms[4]);
        }
        else if (random <= 30)
        {
            controlMalos(5);
        }

        else if (random <= 50)
        {
            controlMalos(6);
        }

        else
        {
            anteriorMalo = false;
            Instantiate(plataforms[0]);
        }
    }
    public void InstFase7()
    {
        random = Random.Range(1, 101);
        if (random <= 5)
        {
            controlMalos(1);
        }
        else if (random <= 10)
        {
            anteriorMalo = false;
            Instantiate(plataforms[2]);
        }
        else if (random <= 15)
        {
            anteriorMalo = false;
            Instantiate(plataforms[3]);
        }
        else if (random <= 20)
        {
            anteriorMalo = false;
            Instantiate(plataforms[4]);
        }
        else if (random <= 30)
        {
            controlMalos(5);
        }

        else if (random <= 40)
        {
            controlMalos(6);
        }

        else if (random <= 50)
        {
            controlMalos(7);
        }

        else
        {
            anteriorMalo = false;
            Instantiate(plataforms[0]);
        }
    }

    public void InstFase8()
    {
        random = Random.Range(1, 101);
        if (random <= 5)
        {
            controlMalos(1);
        }
        else if (random <= 10)
        {
            anteriorMalo = false;
            Instantiate(plataforms[2]);
        }
        else if (random <= 15)
        {
            anteriorMalo = false;
            Instantiate(plataforms[3]);
        }
        else if (random <= 20)
        {
            anteriorMalo = false;
            Instantiate(plataforms[4]);
        }
        else if (random <= 25)
        {
            controlMalos(5);
        }

        else if (random <= 30)
        {
            controlMalos(6);
        }

        else if (random <= 40)
        {
            controlMalos(7);
        }

        else if (random <= 50)
        {
            controlMalos(8);
        }

        else
        {
            anteriorMalo = false;
            Instantiate(plataforms[0]);
        }
    }

    public void InstFase9()
    {
        random = Random.Range(1, 101);
        if (random <= 5)
        {
            controlMalos(1);
        }
        else if (random <= 10)
        {
            anteriorMalo = false;
            Instantiate(plataforms[2]);
        }
        else if (random <= 15)
        {
            anteriorMalo = false;
            Instantiate(plataforms[3]);
        }
        else if (random <= 20)
        {
            anteriorMalo = false;
            Instantiate(plataforms[4]);
        }
        else if (random <= 25)
        {
            controlMalos(5);
        }

        else if (random <= 30)
        {
            controlMalos(6);
        }

        else if (random <= 35)
        {
            controlMalos(7);
        }

        else if (random <= 40)
        {
            controlMalos(8);
        }

        else if (random <= 45)
        {
            controlMalos(9);
        }

        else if (random <= 50)
        {
            controlMalos(10);
        }

        else
        {
            anteriorMalo = false;
            Instantiate(plataforms[0]);
        }
    }

    public  void controlMalos(int nObjeto)
    {
        if (!anteriorMalo)
        {
            anteriorMalo = true;
            Instantiate(plataforms[nObjeto]);
        }
        else
        {
            Instantiate(plataforms[0]);
            anteriorMalo = false;
        }
    }

    
}
