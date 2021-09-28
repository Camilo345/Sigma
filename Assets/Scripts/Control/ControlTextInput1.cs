using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlTextInput1 : MonoBehaviour
{

    public InputField var1;
    public InputField var2;
    public InputField var3;
    public GameObject PanelBueno;
    public GameObject PanelMalo;
    
   
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

        if (var1.text == "5" && var2.text == "5" && var3.text == "5")
        { PanelBueno.SetActive (true); }
        else
        { PanelMalo.SetActive(true); }
    }
}
