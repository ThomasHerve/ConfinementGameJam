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
        transform.position += new Vector3(0,1.8f);
        transform.localScale /= 1.4f;
    }

    public void MoveDown()
    {
        transform.position += new Vector3(0, -1.8f);
        transform.localScale *= 1.4f;
    }
}
