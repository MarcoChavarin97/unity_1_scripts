using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarTexturas : MonoBehaviour
{
    public Material[] materiales; //creamos una lista de materiales
    public GameObject caraACambiar;

    private Renderer dadoTextura;

    void Start()
    {
        dadoTextura = caraACambiar.GetComponent<Renderer>();
        dadoTextura.enabled = true;
        dadoTextura.sharedMaterial = materiales[0]; //llama al primer material de la lista
    }
    
    public void ChangeCubeTexture()
    {
        dadoTextura.sharedMaterial = materiales[1];
        //Este se llama desde unity, para cambiar el material al segundo en la lista
    }
}
