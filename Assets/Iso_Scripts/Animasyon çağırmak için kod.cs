using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animasyonçağırmakiçinkod : MonoBehaviour
{
    public float hizim = 0;
    public bool yukarı;
    public bool sağ;
    public bool sol;
    public bool aşşağı;

    void Update()
    {
      hizim= TopDownMovement.statikim.moveSpeed;
        myFuckingFontions();

        if (Input.GetKey(KeyCode.W))
        {
            WFunction();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            AFunction();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            SFunction();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            DFunction();
        }

        


        void WFunction()
        {
            // W tuşuna basıldığında çalışacak kod buraya yazılır.
            yukarı = true;
            aşşağı = false;
            sol = false;    
            sağ = false;
            if (TopDownMovement.statikim.moveInput.y == 1)
            {
                TopDownMovement.statikim.StateMachine("backrunanimation");
                

            }
           

        }

        void AFunction()
        {
            // A tuşuna basıldığında çalışacak kod buraya yazılır.
            sol = true;
            yukarı =false;
            aşşağı = false;
            sağ = false;
            if (TopDownMovement.statikim.moveInput.x == -1)
            {
                TopDownMovement.statikim.StateMachine("Leftrunanimation");


            }
        }

        void SFunction()
        {
            // S tuşuna basıldığında çalışacak kod buraya yazılır.
            aşşağı = true; 
            yukarı= false;
            sol = false;
            sağ = false;
            if (TopDownMovement.statikim.moveInput.y == -1)
            {
                TopDownMovement.statikim.StateMachine("frontrunanimation");


            }
        }

        void DFunction()
        {
            // D tuşuna basıldığında çalışacak kod buraya yazılır.
            sağ = true;
            yukarı = false;
            aşşağı = false;
            sol = false;
            
            if (TopDownMovement.statikim.moveInput.x == 1)
            {
                TopDownMovement.statikim.StateMachine("rightrunanimation");


            }
        }
    }

    void myFuckingFontions()
    {

        if (TopDownMovement.statikim.moveInput.y == 0 && yukarı == true)
        {
            TopDownMovement.statikim.StateMachine("backidleanimetion");

            Debug.Log("Fucking fonksiyona giriyor");

        }


        if (TopDownMovement.statikim.moveInput.y == 0 && aşşağı == true)
        {
            TopDownMovement.statikim.StateMachine("Frontidleanimation");

            Debug.Log("Fucking fonksiyona giriyor");

        }


        if (TopDownMovement.statikim.moveInput.x == 0 && sol == true)
        {
            TopDownMovement.statikim.StateMachine("Leftsideanimation");

            Debug.Log("Fucking fonksiyona giriyor");

        }


        if (TopDownMovement.statikim.moveInput.x == 0 && sağ == true)
        
            TopDownMovement.statikim.StateMachine("Rightidleanimation");

            

        }



 }

