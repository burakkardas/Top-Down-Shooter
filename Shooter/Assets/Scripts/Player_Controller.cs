using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [Header("Components")]
    public Rigidbody2D rb;
    public Animator animator;

    [Header("Game Play")]
    public float speed;
    private Vector2 movement;
    public int playerHealt = 3;
    void Start()
    {
        
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(
            movement.x * speed,
            movement.y * speed
        );

        runAnim();
    }

    private void runAnim() {
        if(movement.x != 0 || movement.y != 0) {
            animator.SetBool("isRunning", true);
        }
        else {
            animator.SetBool("isRunning", false);
        }
    }
}
