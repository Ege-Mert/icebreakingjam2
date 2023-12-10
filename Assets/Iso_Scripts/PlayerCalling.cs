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
        Instantiate(Player, objectPosisions, Quaternion.identity);
        
    }

 
}
