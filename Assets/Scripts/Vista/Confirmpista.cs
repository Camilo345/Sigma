using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confirmpista: MonoBehaviour
{
    public GameObject panelConfirmPista;
    public GameObject selfpanel;


    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }

    public void AbrirPista()
    {

        panelConfirmPista.SetActive(true);
        selfpanel.SetActive(false);
    }
}

