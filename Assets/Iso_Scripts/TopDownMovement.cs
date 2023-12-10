using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;
    public Vector2 moveInput;
    public static TopDownMovement statikim;
    string currentState;
    public Animator animator;
    public string objectName;
    [SerializeField] GameObject bully;
    public GameObject BullyEngel;
    public GameObject SecondEngel;
    public GameObject ThirtEngel;
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

        

       // if (collision.gameObject.tag == "BullyQuest" && bully.GetComponent<BullyMissionControl>().missionTrue == true)
       // {
       //     Debug.Log("Specific tag object hit");
       //     // Diğer işlemler
       // }

    }
    public void StateMachine(string Statex) 
    {
        if (currentState != Statex) { currentState = Statex; }
        
        animator.Play(currentState);
       

    }

    // 2023-12-10 AI-Tag 
    // This was created with assistance from Muse, a Unity Artificial Intelligence product

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BullyQuest")
        {

            Destroy(BullyEngel);
        }
        if (collision.gameObject.tag == "SecondQuest")
        {
           
            Destroy(SecondEngel);
            
        }
        if (collision.gameObject.tag == "ThirtQuest")
        {

            Destroy(ThirtEngel);

        }


    }

    

}
