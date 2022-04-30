using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Image Vida_Salud;

    public float Vida_Maxima;
    public float Vida_Actual;

    // Update is called once per frame
    void Update()
    {
        Vida_Salud.fillAmount = Vida_Actual / Vida_Maxima;
    }
}
