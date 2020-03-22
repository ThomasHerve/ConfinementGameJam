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
    public static readonly int minCharacterOrder = 0;
    public static readonly int maxCharacterOrder = 5;

    public static void Move(dir direction)
    {
        if (direction == GAUCHE || direction == DROITE)
        {
            player.GetComponent<Mover>().Move(direction);
            camera.GetComponent<Mover>().Move(direction);
            fond.GetComponent<Mover>().Move(direction);
            foreach (var layer in avion){
                layer.GetComponent<Mover>().Move(direction);
            }
        }
        if (direction == HAUT || direction == BAS)
        {
            if ((direction == BAS && avion[1].GetComponent<SpriteRenderer>().sortingOrder == minCharacterOrder - 1) || (direction == HAUT && avion[1].GetComponent<SpriteRenderer>().sortingOrder == maxCharacterOrder + 1))
                return;
            if(direction == HAUT){
                avion[1].GetComponent<SpriteRenderer>().sortingOrder = maxCharacterOrder + 1 ;
                player.GetComponent<MovePlayer>().MoveUp();
            }
            else {
                avion[1].GetComponent<SpriteRenderer>().sortingOrder = minCharacterOrder - 1;
                player.GetComponent<MovePlayer>().MoveDown();
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
