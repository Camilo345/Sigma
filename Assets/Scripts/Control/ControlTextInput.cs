using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlTextInput : MonoBehaviour
{

   public InputField var1;
    public InputField var2;
    public InputField[] InputsRespuesta ;
   // public GameObject PanelBueno;
   // public GameObject PanelMalo;
    public Text answer;
    public ModeloVerificacionRespuestas mvr;
   
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setget()
    {
        string respuesta = "";
       
        for (int i = 0; i < InputsRespuesta.Length; i++)
        {
           
            respuesta += InputsRespuesta[i].text;
        }
        mvr.VerificarRespuesta(respuesta);
       /* if (var1.text == "5" && var2.text == "4")
        { PanelBueno.SetActive (true); }
        else
        { PanelMalo.SetActive(true); }*/
    }
}
