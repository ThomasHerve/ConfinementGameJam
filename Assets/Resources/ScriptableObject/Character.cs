using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/Charater", order = 1)]
public class Character : ScriptableObject
{
    public string Charname;
    public Sprite corp;
    public Sprite haut; //si costume seul le haut et pris 
    public Sprite bas;
    public Sprite accessoire;
    public Sprite chaussure;


    public void  changename(string n)
    {
        Charname = n;
    }
}
