using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullyMissionControl : MonoBehaviour
{
    public bool missionTrue;
    public GameObject pipe;

    private void Start()
    {
        missionTrue = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name == "metalPipe")
            {
                missionTrue = true;
                
                Destroy(pipe);
            }
        }
    
}
