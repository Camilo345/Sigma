using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vistaEscenario : MonoBehaviour
{
    public GameObject escenario;
    public AudioClip Clip;
    public AudioSource Asour;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void cambiarEscenario(GameObject nuevoEscenario)
    {
        if(nuevoEscenario != escenario)
        {
            escenario.SetActive(false);
            escenario = nuevoEscenario;
            escenario.SetActive(true);
            Asour.PlayOneShot(Clip);
        }
      
    }
}
