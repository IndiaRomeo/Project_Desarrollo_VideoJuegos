using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    [SerializeField] private GameObject efecto;
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Score puntaje;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
            Instantiate(efecto, transform.position, Quaternion.identity);
        }
    }
}
