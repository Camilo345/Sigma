using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelRetroalimentacion : MonoBehaviour
{
    public controlCambioEscenario cce;
    public bool esBueno;
    public AudioSource Asou;
    private void OnEnable()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.activeInHierarchy&& Input.GetKeyDown(KeyCode.Return)){
           
            if (esBueno)
            {
                cce.avanzar = true;
                cce.avanzarEscenario();
               
            }
            
            this.gameObject.SetActive(false);
        } 
    }

}
