using UnityEngine;

public class Dialog : MonoBehaviour
{
    public GameObject[] texts;
    public int index = 0;
    void Start()
    {

        print(texts.Length);
        texts[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            index++;
            if (index < texts.Length)
            {
                texts[index].SetActive(true);
                texts[index - 1].SetActive(false);
            }

            else
            {
                print("Mandar a otra escena");
            }


        }
    }


}

