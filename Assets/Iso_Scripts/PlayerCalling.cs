using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCalling : MonoBehaviour
{
    public GameObject Player;
    Vector3 objectPosisions;
    
    void Start()
    {
        objectPosisions = this.transform.position;
        objectPosisions.x += 2.0f;
        Instantiate(Player, objectPosisions, Quaternion.identity);
        
    }

 
}
