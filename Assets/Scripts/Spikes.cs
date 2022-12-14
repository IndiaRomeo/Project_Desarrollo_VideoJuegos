using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    //Variables
    [SerializeField] private float tiempoEntreDa�o;
    private float tiempoSiguienteDa�o;

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
            tiempoSiguienteDa�o -= Time.deltaTime;
            if(tiempoSiguienteDa�o <= 0)
            {
                other.GetComponent<PlayerCombat>().TomarDa�o(5);
                tiempoSiguienteDa�o = tiempoEntreDa�o;
            }
        }
    }
}
