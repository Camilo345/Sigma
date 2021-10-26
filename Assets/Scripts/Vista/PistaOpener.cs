using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistaOpener: MonoBehaviour
{
    public GameObject panelPista;
   

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }

    public void AbrirPista()
    {
        panelPista.SetActive(true);
    }
}

