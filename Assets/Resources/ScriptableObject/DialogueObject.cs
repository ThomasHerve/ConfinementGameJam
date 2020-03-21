using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueObject", menuName = "ScriptableObjects/DialogueObject", order = 1)]
public class DialogueObject : ScriptableObject
{
    public Pair[] dialogue;

    
}

[Serializable]
public struct Pair
{
    public string pnj;
    public string dialogue;
}
