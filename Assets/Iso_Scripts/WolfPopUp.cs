using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfPopUp : MonoBehaviour
{
    [SerializeField] GameObject Wolf;
    private void Start()
    {
    }
    private void Update()
    {
        //  Debug.Log(""+bully.GetComponent<BullyMissionControl>().missionTrue);
        if (Wolf.GetComponent<WolfMissionControl>().ThirdmissionTrue)
        {
            GetComponent<SpriteRenderer>().enabled = false;

        }
    }
}
