using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escenario : MonoBehaviour
{
    public string NombrePersonaje;
    public float tiempoEntrePalabras;
    public Text txtNombre;
    public Text txtDialogo;
    public List<string> characteresDialogo;
    [TextArea]
    public string TextoDialogo;

    private string dialogo;
    private int palabraActual=0;

    // Start is called before the first frame update

    private void OnEnable()
    {
        characteresDialogo = new List<string>();
        txtNombre.text = NombrePersonaje;
      
        palabraActual = 0;
        obtenerCaracteres();
        StartCoroutine(cargarTexto(tiempoEntrePalabras));
    }

    private void OnDisable()
    {
        dialogo = "";
        txtDialogo.text = "";
        txtNombre.text = "";
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void obtenerCaracteres()
    {
        char[] caracteres;
        string[] palabras = TextoDialogo.Split(' ');
        for (int i = 0; i < palabras.Length; i++)
        {
            caracteres = palabras[i].ToCharArray();
            string primerLetra = " " + caracteres[0];
            characteresDialogo.Add(primerLetra);
            for(int j = 1; j < caracteres.Length; j++)
            {
                characteresDialogo.Add(""+caracteres[j]);
            }
        }
        
    }

    IEnumerator cargarTexto(float tiempo)
    {
       
        yield return new WaitForSeconds(tiempo);
        if (palabraActual <= characteresDialogo.Count && this.gameObject.activeInHierarchy)
        {
            dialogo += characteresDialogo[palabraActual];
            txtDialogo.text = dialogo;
            palabraActual++;
            StartCoroutine(cargarTexto(tiempoEntrePalabras));          
        }
        else
        {
            palabraActual = 0;
        }

    }
}
