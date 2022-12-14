using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    //Variables
    [SerializeField] private float tiempoEntreDaño;
    private float tiempoSiguienteDaño;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            tiempoSiguienteDaño -= Time.deltaTime;
            if(tiempoSiguienteDaño <= 0)
            {
                other.GetComponent<PlayerCombat>().TomarDaño(5);
                tiempoSiguienteDaño = tiempoEntreDaño;
            }
        }
    }
}
