using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMissionControl : MonoBehaviour
{
    public bool ThirdmissionTrue;
    public GameObject koyun;

    private void Start()
    {
        ThirdmissionTrue = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Sheepp")
        {
            ThirdmissionTrue = true;
            Destroy(koyun);
        }
    }
}
