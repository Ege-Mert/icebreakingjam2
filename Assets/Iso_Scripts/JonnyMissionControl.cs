using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JonnyMissionControl : MonoBehaviour
{
    public bool jonnyMissionControl;
    public GameObject kalas;

    private void Start()
    {
        jonnyMissionControl = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "kalas")
        {
            jonnyMissionControl = true;

            Destroy(kalas);
        }
    }
}
