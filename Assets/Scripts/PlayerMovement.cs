using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rigidBody;

    private Vector2 movementInput;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
     void Update()
    {
         if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Backward");
        }
         if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetTrigger("BackwardPause");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Forward");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("ForwardPause");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Left");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("LeftPause");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Right");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("RightPause");
        }
    }
    private void FixedUpdate()
    {
        rigidBody.velocity = movementInput * moveSpeed;
    }
    private void LateUpdate()
    {

    }
    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();

    }
}
