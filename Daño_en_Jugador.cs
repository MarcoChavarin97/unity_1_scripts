using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño_en_Jugador : MonoBehaviour
{
    public float Danionos;
    public GameObject ObjetivoADañar;

    void OnTriggerEnter (Collider colaider)
    {
        if (colaider.tag == "Player")
        {
            ObjetivoADañar.GetComponent<BarraDeVida>().Vida_Actual -= Danionos;
        }

        if (colaider.tag == "Enemigo")
        {
            Debug.Log("Esto es un enemigo"); 
        }
    }
}
