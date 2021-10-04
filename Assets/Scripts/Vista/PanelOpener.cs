using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject panelBueno;
    public GameObject panelMalo;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }

    public void AbrirPanel(bool esCorrecto)
    {
        if (esCorrecto)
        {
            panelBueno.SetActive(true);
        }
        else
        {
            panelMalo.SetActive(true);
        }
    }
}

