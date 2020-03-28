using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public Inventory inv;
    public bool tetine, madeleine, medoc;
    private bool Inside;
    public GameObject press;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            press.SetActive(true);
            Inside = true;
            Debug.Log("passe");
        }
    }

    public void Update()
    {
        if (Inside && Input.GetKeyDown(KeyCode.E))
        {
            if (tetine)
            {
                inv.AddTetine();
                Destroy(this.gameObject);
            }
            else if (madeleine)
            {
                inv.AddMadeleine();
                Destroy(this.gameObject);
            }
            else if (medoc)
            {
                inv.AddMedoc();
                Destroy(this.gameObject);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            press.gameObject.SetActive(false);
            Inside = false;
            Debug.Log("passe222");
        }

    }


}
