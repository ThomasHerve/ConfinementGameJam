using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private Object[] dialoguesObject;
    public DialogueObject[] dialogues;
    private void Start()
    {
        dialoguesObject = Resources.LoadAll("ScriptableObject/Dialogues",typeof(DialogueObject));
        dialogues = new DialogueObject[dialoguesObject.Length];
        for(int i = 0; i < dialoguesObject.Length; i++)
        {
            dialogues[i] = dialoguesObject[i] as DialogueObject;
        }
    }

    public void displayDialogue(string dialogueName)
    {
        foreach(DialogueObject d in dialogues)
        {
            if(d.name == dialogueName)
            {
                bool canProc = true;
                foreach(Pair p in d.dialogue)
                {
                    if (!GameObject.Find(p.pnj).GetComponent<Dialogue>().isInteractable()) canProc = false;
                }
                if(canProc)StartCoroutine(execDialogue(d));
            }
        }
    }
    
    private IEnumerator execDialogue(DialogueObject d)
    {
        foreach (Pair p in d.dialogue)
        {
            GameObject.Find(p.pnj).GetComponent<Dialogue>().setInteractable(false);
        }
        foreach (Pair p in d.dialogue)
        {
            yield return GameObject.Find(p.pnj).GetComponent<Dialogue>().RoutineDialogue(p.dialogue,true);
        }
        foreach (Pair p in d.dialogue)
        {
            GameObject.Find(p.pnj).GetComponent<Dialogue>().setInteractable(true);
        }
    }

}
