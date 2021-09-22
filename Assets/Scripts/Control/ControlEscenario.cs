using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEscenario : MonoBehaviour
{
     public GameObject escenarioActual;
    public vistaEscenario ve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void enviarEscenario(GameObject escenario)
    {
        escenarioActual = escenario;
        ve.cambiarEscenario(escenario);
    }
}
