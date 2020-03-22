using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAvionBg0 : Mover
{
    // Start is called before the first frame update
    void Start()
    {
        MouvementsManager.SetAvionBg(this.gameObject,0);
        speed = MouvementsManager.speedavionbg0;

    }


}
