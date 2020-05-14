using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Acessorios", menuName = "ScriptableObjects/conejo", order = 1)]
public class AccesoriosScriptable : ScriptableObject
{
    public Sprite[] accesorios = new Sprite[2];
}
