using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAvionBg1 : Mover
{
    // Start is called before the first frame update
    void Start()
    {
        MouvementsManager.SetAvionBg(this.gameObject, 1);
        speed = MouvementsManager.speedavionbg1;
    }

}
