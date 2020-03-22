using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Dialogue : MonoBehaviour
{
    public GameObject DialogueBox;
    private GameObject myDialogueBox;
    public Vector2 offset = new Vector2(0,0);
    private TextMeshProUGUI text;

    private GameObject canvas;
    private float dialogueSpeed = 0.1f;
    private float finishTime = 2.0f;
    private bool interactable = true;
    void Start()
    {
        myDialogueBox = Instantiate(DialogueBox,new Vector3(0,0,0),Quaternion.identity);
        myDialogueBox.SetActive(false);
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        myDialogueBox.transform.SetParent(canvas.transform);
        text = myDialogueBox.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        myDialogueBox.GetComponent<RectTransform>().position = transform.position+new Vector3(offset.x, offset.y, 0);
    }

    public IEnumerator RoutineDialogue(string dialogue, bool diseaperOnFinish)
    {
        text.SetText("");
        myDialogueBox.SetActive(true);
        foreach (char c in dialogue)
        {
            text.SetText(text.text + c);
            yield return new WaitForSeconds(dialogueSpeed);
        }
        if (diseaperOnFinish)
        {
            yield return new WaitForSeconds(finishTime);
            myDialogueBox.SetActive(false);
        }
    }

    public void setInteractable(bool v)
    {
        interactable = v;
    }

    public bool isInteractable()
    {
        return interactable;
    }


}
