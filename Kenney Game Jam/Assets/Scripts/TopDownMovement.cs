using System.Threading;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;

public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D rb;
    private Animator animator;

    private Vector2 movement;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = movement * moveSpeed;
       // movement.x = Input.GetAxisRaw("Horizontal");
       // movement.y = Input.GetAxisRaw("Vertical");
    }

    //private void FixedUpdate()
    //{
        
        //rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.deltaTime);
       

    //}
    public void Move(InputAction.CallbackContext context)
    {
        animator.SetBool("isWalking", true);
        if (context.canceled)
        {
            animator.SetBool("isWalking", false);
            
            animator.SetFloat("LastInputX", movement.x);
            animator.SetFloat("LastInputY", movement.y);

        }
        movement=context.ReadValue<Vector2>();
        animator.SetFloat("InputX", movement.x);
        animator.SetFloat("InputY", movement.y);

    }
}
