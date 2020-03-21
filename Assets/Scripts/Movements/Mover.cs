using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MouvementsManager;
using static MouvementsManager.dir;

public class Mover : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Move(dir d)
    {
        Vector3 mouvement = new Vector3(0, 0);
        if (d == GAUCHE)
            mouvement = new Vector3(-1, 0);
        if (d == DROITE)
            mouvement = new Vector3(1, 0);

        transform.position += mouvement * speed;
    }

}
