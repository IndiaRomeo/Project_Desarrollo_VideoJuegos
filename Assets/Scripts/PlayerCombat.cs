using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCombat : MonoBehaviour
{
    //Variables
    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;
    [SerializeField] private BarHealth barraDeVida;

    // Start is called before the first frame update
    void Start()
    {
        vida = maximoVida;
        barraDeVida.InicializarBarraDeVida(vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TomarDaño(float daño)
    {
        vida -= daño;
        barraDeVida.CambiarVidaActual(vida);
        if(vida <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void Curar(float curacion)
    {
        if((vida + curacion) > maximoVida)
        {
            vida = maximoVida;
        } else
        {
            vida += curacion;
        }
    }
}
