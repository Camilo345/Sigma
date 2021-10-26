using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePista: MonoBehaviour
{
    public GameObject WholePanel;
   

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }

    public void CerrarPista()
    {

        WholePanel.SetActive(false);
        gameObject.SetActive(false);
    }
}

