using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;
    public Vector2 moveInput;
    public static TopDownMovement statikim;
    string currentState;
    public Animator animator;
    public string objectName;
    private void Start()
    {
        animator = GetComponent<Animator>();
        statikim = this;
    }
    private void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        
        rb2d.velocity = moveInput * moveSpeed;
    }
    public void StateMachine(string Statex) 
    {
        if (currentState != Statex) { currentState = Statex; }
        
        animator.Play(currentState);
    }
}
