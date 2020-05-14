using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public string scena;

    public void OnMouseDown()
    {
        SceneManager.LoadScene(scena);
    }
}
