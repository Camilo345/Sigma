using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlCambioEscenario : MonoBehaviour
{
    public ManagerEscenario me;
    public bool avanzar = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            retrocerEscenario();
          
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            avanzarEscenario();
          
        }
    }


    public void avanzarEscenario()
    {
        if(avanzar)
        me.cambiarEscenario(1);
      
    }

    public void retrocerEscenario()
    {
        if (avanzar)
            me.cambiarEscenario(-1);

    }

   
}
