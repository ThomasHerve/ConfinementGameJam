using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private void Awake()
    {

    }

    public void OnMove(InputValue value)
    {
        if (IsLeft(value))
            MouvementsManager.Move(MouvementsManager.dir.GAUCHE);
        else if (IsRight(value))
            MouvementsManager.Move(MouvementsManager.dir.DROITE);
        else
        {
            var v = value.Get<Vector2>();
            Debug.Log(v);
        }
    }

    public void OnInteract(InputValue value)
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<DialogueManager>().displayDialogue("Les pates");
    }

    private bool IsLeft(InputValue value)
    {
        return value.Get<Vector2>().x == -1 && value.Get<Vector2>().y == 0;
    }
    private bool IsRight(InputValue value)
    {
        return value.Get<Vector2>().x == 1 && value.Get<Vector2>().y == 0;
    }
}
