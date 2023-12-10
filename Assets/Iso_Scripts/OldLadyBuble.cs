using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldLadyBuble : MonoBehaviour
{
    [SerializeField] GameObject OldLady;
    private void Start()
    {
    }
    private void Update()
    {
        //  Debug.Log(""+bully.GetComponent<BullyMissionControl>().missionTrue);
        if (OldLady.GetComponent<OldLadyMissionControl>().SecondmissionTrue)
        {
            GetComponent<SpriteRenderer>().enabled = false;

        }
    }

}
