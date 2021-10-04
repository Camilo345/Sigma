using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeloVerificacionRespuestas : MonoBehaviour
{
    public string respuesta;
    public ControlRespuestas cr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VerificarRespuesta(string ResUsuario)
    {
        Debug.Log(ResUsuario);
        bool esCorrecto = false;
        if (ResUsuario == respuesta)
        {
            esCorrecto = true;
        }
        cr.EnviarValidacion(esCorrecto);
    }
}
