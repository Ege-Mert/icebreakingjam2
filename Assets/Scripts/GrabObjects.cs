using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObjects : MonoBehaviour
{
    public Transform grabDetect;    
    public Transform itemHolder;
    public float rayDist;

    private GameObject grabbedObject;

    public LayerMask ItemLayer;

    public bool objectDetect;

    void Update()
    {

        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right , rayDist, ItemLayer);
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (grabCheck.collider != null && grabbedObject == null)
            {
                objectDetect = true;
                grabbedObject = grabCheck.collider.gameObject;
                grabCheck.collider.gameObject.transform.parent = itemHolder;
                grabCheck.collider.gameObject.transform.position = itemHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            }
            else
            {
                if (grabbedObject != null)
                {
                    grabbedObject.transform.parent = null;
                    grabbedObject.GetComponent<Rigidbody2D>().isKinematic = false;
                }
                grabbedObject = null;
            }
        }
        Debug.DrawRay(grabDetect.position, Vector2.right * transform.localScale);
    }
}
