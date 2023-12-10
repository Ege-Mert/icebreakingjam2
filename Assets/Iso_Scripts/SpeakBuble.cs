using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakBuble : MonoBehaviour
{
    [SerializeField] GameObject bully;
    private void Start()
    {
    }
    private void Update()
    {
      //  Debug.Log(""+bully.GetComponent<BullyMissionControl>().missionTrue);
      if (bully.GetComponent<BullyMissionControl>().missionTrue) 
        {
            GetComponent<SpriteRenderer>().enabled = false;
        
        }
    }
}
