using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAvionBg2 : Mover
{
    // Start is called before the first frame update
    void Start()
    {
        MouvementsManager.SetAvionBg(this.gameObject, 2);
        speed = MouvementsManager.speedavionbg2;
    }

}
