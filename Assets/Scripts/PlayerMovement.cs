using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float JumpForce;
    public float Speed;

    Vector3 initPosition;

    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private float Horizontal;
    private bool Grounded;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        initPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        //Cambiar orientación
        if (Horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        //Transicción al correr
        //Animator.SetBool("running", Horizontal != 0.0f);

        //Evitar que se repita el salto
        Debug.DrawRay(transform.position, Vector3.down * 0.2f, Color.red);
        if(Physics2D.Raycast(transform.position, Vector3.down, 0.2f))
        {
            Grounded = true;
        }
        else
        {
            Grounded = false;
        }

        //Salto
        if (Input.GetKeyDown(KeyCode.UpArrow) && Grounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Rigidbody2D.velocity.y);
    }

    public void ResetPosition()
    {
        this.transform.position = initPosition;
    }
}
