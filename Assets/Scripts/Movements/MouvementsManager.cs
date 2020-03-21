using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MouvementsManager.dir;

public static class MouvementsManager
{
    public enum dir {
        HAUT,
        BAS,
        GAUCHE,
        DROITE
    }

    private static GameObject player;
    private static GameObject camera;
    private static GameObject fond;
    private static GameObject[] avion = new GameObject[3];

    [SerializeField]
    public static float speedplayer = 0.5f;
    public static float speedfond = 0.1f;
    public static float speedavionbg0 = 0.2f;
    public static float speedavionbg1 = 0.3f;
    public static float speedavionbg2 = 0.4f;


    public static void Move(dir direction)
    {
        if (direction == GAUCHE || direction == DROITE)
        {
            player.GetComponent<Mover>().Move(direction);
            camera.GetComponent<Mover>().Move(direction);
            fond.GetComponent<Mover>().Move(direction);
            foreach (var layer in avion)
            {
                layer.GetComponent<Mover>().Move(direction);
            }
        }
    }



    public static void SetPlayer(GameObject _player)
    {
        player = _player;
    }
    public static void SetCamera(GameObject _camera)
    {
        camera = _camera;
    }
    public static void SetFond(GameObject _fond)
    {
        fond = _fond;
    }
    public static void SetAvionBg(GameObject _avion, int layer)
    {
        avion[layer] = _avion;
    }

}
