using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : Mover
{
    // Start is called before the first frame update
    void Start()
    {
        MouvementsManager.SetPlayer(this.gameObject);
        speed = MouvementsManager.speedplayer;

    }


}
