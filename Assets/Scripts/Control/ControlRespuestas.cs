using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRespuestas : MonoBehaviour
{
    public PanelOpener po;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnviarValidacion(bool esCorrecto)
    {
        po.AbrirPanel(esCorrecto);
    }
}
