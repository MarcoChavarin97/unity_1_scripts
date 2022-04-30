using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curacion_Jugador : MonoBehaviour
{
    public float Curitas;
    public GameObject ObjetivoACurar;

    void OnTriggerEnter(Collider colaider)
    {
        if (colaider.tag == "Player")
        {
            ObjetivoACurar.GetComponent<BarraDeVida>().Vida_Actual += Curitas;
        }

        if (colaider.tag == "Enemigo")
        {
            Debug.Log("No Cura Enemigos");
        }
    }
}
