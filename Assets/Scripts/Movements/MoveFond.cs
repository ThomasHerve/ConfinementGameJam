using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFond : Mover
{
    // Start is called before the first frame update
    void Start()
    {
        MouvementsManager.SetFond(this.gameObject);
        speed = MouvementsManager.speedfond;
    }

}
