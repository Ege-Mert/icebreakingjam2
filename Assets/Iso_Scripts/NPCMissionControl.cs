using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMissionControl : MonoBehaviour
{
    public bool npcMission;
    public GameObject cam;

    private void Start()
    {
        npcMission = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "kum")
        {
            npcMission = true;

            Destroy(cam);
        }
    }
}
