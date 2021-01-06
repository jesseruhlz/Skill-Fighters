using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// will need to add code for animation later
// will also need to add code for audio sources later

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    private Collider2D coll;

    public CharacterController2D controller;
    public Animator animator;

    public float runspeed = 25f;
    float horizontalMove = 0f;
    bool jumpFlag = false;
    bool jump = false;
    bool crouch = false;

    private enum State { falling }
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
    }

     void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;
   
        if (Input.GetButtonDown("Jump"))
        {
            //player will jump vertically
            jump = true;
            //rb.velocity = new Vector2(rb.velocity.x, 10f);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
        

        //change = Vector2.zero;
    }


    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);

        jump = false;
        //rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }
}
