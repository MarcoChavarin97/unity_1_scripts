using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Importante, con este funcionan las librerias
//para cambiar de escenas

public class Escenas_cambio : MonoBehaviour
{
    public void EscenaJuego()//metodo para buscar
    {
        SceneManager.LoadScene("Nivel_1"); //cargador de escena y nivel a cargar
    }
}
//este script es para un boton https://www.youtube.com/watch?v=zGvM2pM0QzA