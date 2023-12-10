using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldLadyMissionControl : MonoBehaviour
{
    public bool SecondmissionTrue;
    public GameObject yün;

    private void Start()
    {
        SecondmissionTrue = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "yün")
        {
            SecondmissionTrue = true;
            
            Destroy(yün);
        }
    }
}
