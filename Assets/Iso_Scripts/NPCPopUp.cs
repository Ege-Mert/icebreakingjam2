using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPopUp : MonoBehaviour
{
    [SerializeField] GameObject npc;
    private void Start()
    {
    }
    private void Update()
    {
        //  Debug.Log(""+bully.GetComponent<BullyMissionControl>().missionTrue);
        if (npc.GetComponent<NPCMissionControl>().npcMission)
        {
            GetComponent<SpriteRenderer>().enabled = false;

        }
    }
}
