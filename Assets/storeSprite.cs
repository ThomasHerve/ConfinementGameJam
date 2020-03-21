using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storeSprite : MonoBehaviour
{
    public Character c;

    private void Awake()
    {
        Refresh();
    }

    private void Refresh()
    {
        GetComponent<SpriteRenderer>().sprite = c.corp;
        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = c.accessoire;
        transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = c.haut;
        transform.GetChild(2).GetComponent<SpriteRenderer>().sprite = c.bas;
        transform.GetChild(3).GetComponent<SpriteRenderer>().sprite = c.chaussure;
    }


    public void SetCorp(Sprite s)
    {
        c.corp = s;
        Refresh();
    }

    public void SetHaut(Sprite s)
    {
        c.haut = s;
        Refresh();
    }


    public void SetUniform(Sprite s)
    {
        c.haut = s;
        c.bas = null;
        c.chaussure = null;
        Refresh();
    }

    public void SetBas(Sprite s)
    {
        c.bas = s;
        Refresh();
    }

    public void SetChaussure(Sprite s)
    {
        c.chaussure= s;
        Refresh();
    }

    public void SetAccessoire(Sprite s)
    {
        c.accessoire = s;
        Refresh();
    }





}
