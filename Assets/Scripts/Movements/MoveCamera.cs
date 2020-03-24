using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MouvementsManager;

public class MoveCamera : Mover
{
    // Start is called before the first frame update
    void Start()
    {
        MouvementsManager.SetCamera(this.gameObject);
        speed = MouvementsManager.speedplayer;
    }

}
