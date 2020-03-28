using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private bool tetine, madelene, medoc;
    public GameObject madeleneIMG, tetineIMG, medocIMG;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddTetine()
    {
        tetine = true;
        tetineIMG.SetActive(true);
    }

    public void AddMadeleine()
    {
        madelene = true;
        madeleneIMG.SetActive(true);
    }

    public void AddMedoc()
    {
        medoc = true;
        medocIMG.SetActive(true);
    }

    public void RemoveTetine()
    {
        tetine = false;
        tetineIMG.SetActive(false);
    }

    public void RemoveMadeleine()
    {
        madelene = false;
        madeleneIMG.SetActive(false);
    }

    public void RemoveMedoc()
    {
        medoc = false;
        medocIMG.SetActive(false);
    }



}

