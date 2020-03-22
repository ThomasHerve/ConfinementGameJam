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

    public void MoveUp()
    {
        transform.position += new Vector3(0,1);
        transform.localScale /= 1.2f;
    }

    public void MoveDown()
    {
        transform.position += new Vector3(0, -1);
        transform.localScale *= 1.2f;
    }
}
