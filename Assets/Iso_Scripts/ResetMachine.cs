using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class ResetMachine : MonoBehaviour
{
    public GameObject laughingManPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "laugh")
        {
            Destroy(collision.gameObject);
            Instantiate(laughingManPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

}