using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineController : MonoBehaviour
{
    public GameObject itemToReceive;
    public GameObject objectToReturn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming the player is giving an item
        {
            // Destroy the item given to the machine
            Destroy(other.gameObject);

            // Instantiate and return the new object
            Instantiate(objectToReturn, transform.position, Quaternion.identity);
        }
    }
}
