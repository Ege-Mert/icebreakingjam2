using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullyMissionControl : MonoBehaviour
{
    public bool missionTrue;
    public GameObject pipe;
    [SerializeField] GameObject bullyBarrier;
    public AudioSource Bitti;
    public AudioClip bittii;

    private void Start()
    {
        missionTrue = false;
        Bitti = gameObject.AddComponent<AudioSource>();
        Bitti.clip = bittii;
    }

    void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "metalPipe")
            {
                missionTrue = true;
            Destroy(collision.gameObject);
            Destroy(pipe);
            Destroy(bullyBarrier);
            Bitti.PlayOneShot(bittii);
            }
        }
    
}
