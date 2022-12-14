using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlatform : MonoBehaviour
{
    //Variables
    [SerializeField] private float speed;
    [SerializeField] private bool esDerecha;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(esDerecha == true)
        {
            transform.position += Vector3.right * Time.deltaTime;
        }
        if(esDerecha == false)
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
    }
}
