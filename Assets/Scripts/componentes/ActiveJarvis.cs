using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveJarvis : MonoBehaviour
{
    public ManagerEscenario me;
    public GameObject jarvis;
    public bool jarvisIsActive;
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
        if (me.escenaActual < 2 && !jarvis.activeInHierarchy)
        {
            jarvis.SetActive(true);
        }

        if (me.escenaActual >= 2 && jarvis.activeInHierarchy)
        {
            jarvis.SetActive(false);
        }
    }
}
