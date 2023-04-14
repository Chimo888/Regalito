using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    // Start is called before the first frame update

    public float Jumpforce;
    public float Speed;



    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private float Horizontal;
    private bool Grounded; //ovale tru ovale fols

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    // que miras pervertida
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Horizontal < 0) transform.localScale = new Vector3(-0.9f, 0.9f, 0.9f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);


        Animator.SetBool("corriendo", Horizontal != 0.0f);

        Debug.DrawRay(transform.position, Vector3.down * 0.3f, Color.red);
        if (Physics2D.Raycast(transform.position, Vector3.down, 0.3f))

           //felicidades puta zorra ⭒＊*•✩•*˚⍣˚*•✩•*＊⭒

        {
            Grounded = true;
        }
        else Grounded = false;

        if (Input.GetKeyDown(KeyCode.Space)&& Grounded)
        {
            Jump();
        }
        
        if (FindObjectOfType<Reencarnacion>().Amen == 1)
        {
            transform.position = (new Vector2(-0.11f, -1.236f));
            FindObjectOfType<Reencarnacion>().Amen = 0;
        }

    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * Jumpforce);
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
    }
}
