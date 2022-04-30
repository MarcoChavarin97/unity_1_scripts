using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Da�o_en_Jugador : MonoBehaviour
{
    public float Danionos;
    public GameObject ObjetivoADa�ar;

    void OnTriggerEnter (Collider colaider)
    {
        if (colaider.tag == "Player")
        {
            ObjetivoADa�ar.GetComponent<BarraDeVida>().Vida_Actual -= Danionos;
        }

        if (colaider.tag == "Enemigo")
        {
            Debug.Log("Esto es un enemigo"); 
        }
    }
}
