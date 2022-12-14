using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarHealth : MonoBehaviour
{
    private Slider slider;
    private Animator animator;

    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarVidaMaxima(float vidaMaxima)
    {
        slider.maxValue = vidaMaxima;
    }

    public void CambiarVidaActual(float cantidadVida)
    {
        slider.value = cantidadVida;
        animator.SetTrigger("Golpe");
    }

    public void InicializarBarraDeVida(float cantidadVida)
    {
        CambiarVidaMaxima(cantidadVida);
        CambiarVidaActual(cantidadVida);
    }
}
