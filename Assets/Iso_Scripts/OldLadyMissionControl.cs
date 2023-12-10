using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldLadyMissionControl : MonoBehaviour
{
    public bool SecondmissionTrue;
    public GameObject yün;
    [SerializeField] GameObject oldladyBarrier;

    private void Start()
    {
        SecondmissionTrue = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wool")
        {
            SecondmissionTrue = true;
            Destroy(oldladyBarrier);
            Destroy(collision.gameObject);
        }
    }
}
