using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JonnyPopUp : MonoBehaviour
{
    [SerializeField] GameObject jonny;
    
    private void Update()
    {
        //  Debug.Log(""+bully.GetComponent<BullyMissionControl>().missionTrue);
        if (jonny.GetComponent<JonnyMissionControl>().jonnyMissionControl)
        {
            GetComponent<SpriteRenderer>().enabled = false;

        }
    }
}
