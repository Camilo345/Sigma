using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEscenario : MonoBehaviour
{
    public GameObject[] escenas;
    public int escenaActual = 0;
    public ControlEscenario ce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiarEscenario(int aumentar)
    {
     
        int escenaActualAUX = escenaActual;
        escenaActual += aumentar;
    
        if (escenaActual < 0 || escenaActual >= escenas.Length)
        {
            escenaActual = escenaActualAUX;
          
        }
 
     
        GameObject escena = escenas[escenaActual];
        ce.enviarEscenario(escena);
    }
}
