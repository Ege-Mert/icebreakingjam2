using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMissionControl : MonoBehaviour
{
    public bool npcMission;
    public GameObject sand;

    private void Start()
    {
        npcMission = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "sand")
        {
            npcMission = true;
            Destroy(collision.gameObject);
            Destroy(sand);
            
        }
    }
}
