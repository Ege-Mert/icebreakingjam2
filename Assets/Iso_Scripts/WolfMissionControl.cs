using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMissionControl : MonoBehaviour
{
    public bool ThirdmissionTrue;
    public GameObject koyun;
    [SerializeField] GameObject wolfBarrier;

    private void Start()
    {
        ThirdmissionTrue = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "lamb")
        {
            ThirdmissionTrue = true;
            Destroy(wolfBarrier);
            Destroy(koyun);
            Destroy(collision.gameObject);
        }
    }
}
