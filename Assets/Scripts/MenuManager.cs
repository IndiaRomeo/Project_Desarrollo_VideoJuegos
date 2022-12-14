using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void BtnJugar()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void BtnSalir()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}
