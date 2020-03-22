using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapController : MonoBehaviour
{
   public Animator corp,chaussure,haut,bas,accessoire;
    public Animator actif;
    private Animator wait, wait2;
    private bool désactivation,activation,f;
    private float t;
    public float waitanim;

    public void  Start()
    {
        wait = null;
        actif = corp;
        désactivation = false;
        activation = false;
        wait2 = null;
        waitanim = 0.1f;
        f = false;
    }

    public void Update()
    {
        if (activation)
        {
            if (!f)
            {
                actif = wait;
            actif.SetTrigger("pop");
                t = Time.time;
                f = true;
            }
            if (Time.time - t > waitanim)
            {
                activation = false;
                f = false;
            }
        }
        else if (désactivation)
        {
            if (!f)
            {
                actif.SetTrigger("depop");
                t = Time.time;
                f = true;
            }
            if (Time.time - t > waitanim)
            {
                activation = true;
                désactivation = false;
                f = false;
            }
        }
    }
    public void SwapAnim(string id)
    {
        wait = ChooseWaiter(id);
        désactivation = true;
    }
    private Animator ChooseWaiter(string id)
    {
        switch (id)
        {
            case "c":
                return corp;
            case "ch":
                return chaussure;
            case "h":
                return haut;
            case "b":
                return bas;
            case "a":
                return accessoire;
            default:
                return null;
        }
    }




}
