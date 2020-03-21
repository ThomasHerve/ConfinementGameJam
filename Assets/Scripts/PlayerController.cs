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
        var v = value.Get<Vector2>();
        Debug.Log(v);
    }

    public void OnInteract(InputValue value)
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<DialogueManager>().displayDialogue("Les pates");
    }
}
