using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldLadyMissionControl : MonoBehaviour
{
    public bool SecondmissionTrue;
    public GameObject yün;
    [SerializeField] GameObject oldladyBarrier;
    public AudioSource calgi;
    public AudioClip win;

    private void Start()
    {
        SecondmissionTrue = false;
        calgi = gameObject.AddComponent<AudioSource>();
        calgi.clip = win;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wool")
        {
            SecondmissionTrue = true;
            Destroy(oldladyBarrier);
            Destroy(collision.gameObject);
            calgi.PlayOneShot(win);
        }
    }
}
