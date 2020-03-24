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

    private static bool PlayerIsUp = true;

    [SerializeField]
    public static float speedplayer = 0.5f;
    public static float speedfond = 0.1f;
    public static float speedavionbg0 = 0.2f;
    public static float speedavionbg1 = 0.3f;
    public static float speedavionbg2 = 0.4f;
    public static readonly int  minmove = -2;
    public static readonly int maxmove = 3;

    public static void Move(dir direction)
    {
        if (direction == GAUCHE || direction == DROITE)
        {
            player.GetComponent<Mover>().Move(direction);
            if (MaxMove(direction))
                return;

            camera.GetComponent<Mover>().Move(direction);
            fond.GetComponent<Mover>().Move(direction);
            foreach (var layer in avion){
                layer.GetComponent<Mover>().Move(direction);
            }
        }
        if (direction == HAUT || direction == BAS)
        {
            if ((direction == BAS && !PlayerIsUp) || (direction == HAUT && PlayerIsUp))
                return;
            PlayerIsUp = !PlayerIsUp;
            if (direction == HAUT){
                SortingLayer character = SortingLayer.layers[3];
                SortingLayer.layers[3] = SortingLayer.layers[2];
                SortingLayer.layers[2] = character;

                player.GetComponent<MovePlayer>().MoveUp();
            }
            else {
                SortingLayer character = SortingLayer.layers[2];
                SortingLayer.layers[2] = SortingLayer.layers[3];
                SortingLayer.layers[3] = character;
                
                player.GetComponent<MovePlayer>().MoveDown();
            }

        }

    }

    private static bool MaxMove(dir d)
    {
        if (d == dir.GAUCHE && MouvementsManager.GetPlayer().transform.position.x <= minmove)
            return true;
        if (d == dir.DROITE && MouvementsManager.GetPlayer().transform.position.x >= maxmove)
            return true;
        return false;
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

    public static GameObject GetPlayer()
    {
        return player;
    }
}
