using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapController : MonoBehaviour
{
   public Animator corp,chaussure,haut,bas,accessoire;
    public Animator actif;
    private Animator wait, wait2;
    public bool désactivation,activation,f;
    private float t;
    public float waitanim;
    public GameObject test;

    public void  Start()
    {
        wait = null;
        actif = corp;
        désactivation = false;
        activation = false;
        wait2 = null;
        f = false;
    }

    public void Update()
    {
        checkProblem();
        if (activation)
        {
            if (!f)
            {
                actif = wait;
                wait = null;
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
        if (!activation && !désactivation)
        {
            wait = ChooseWaiter(id);
            désactivation = true;
        }
        
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
    private void checkProblem() {

    }





}
