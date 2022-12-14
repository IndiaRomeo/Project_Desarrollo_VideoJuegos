using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPause : MonoBehaviour
{
    //Variables
    [SerializeField] private GameObject btnPausa;
    [SerializeField] private GameObject menuPausa;

    private bool juegoPausado  = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                Reanudar();
                AudioSource[] audios = FindObjectsOfType<AudioSource>();

                foreach (AudioSource a in audios)
                {
                    a.Play();
                }
            }
            else
            {
                Pausa();
                AudioSource[] audios = FindObjectsOfType<AudioSource>();

                foreach(AudioSource a in audios)
                {
                    a.Pause();
                }
            }
        }
    }

    //Pausar juego
    public void Pausa()
    {
        juegoPausado = true;
        Time.timeScale = 0;
        btnPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void Reanudar()
    {
        juegoPausado = false;
        Time.timeScale = 1;
        btnPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void Reiniciar()
    {
        juegoPausado = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Cerrar()
    {
        Debug.Log("Cerrando juego...");
        Application.Quit();
    }
}
