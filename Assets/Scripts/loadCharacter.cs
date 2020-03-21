using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadCharacter : MonoBehaviour
{
    public Character c;

    private void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = c.corp;
        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = c.accessoire;
        transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = c.haut;
        transform.GetChild(2).GetComponent<SpriteRenderer>().sprite = c.bas;
        transform.GetChild(3).GetComponent<SpriteRenderer>().sprite = c.chaussure;
    }
}
