using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class ResetMachine : MonoBehaviour
{
    public GameObject clothes;
    public GameObject cloth;
    public GameObject wool;
    public GameObject metalObjects;
    public GameObject metalPipe;
    public GameObject glassObject;
    public GameObject glass;
    public GameObject sand;
    public GameObject stone;
    public GameObject chair;
    public GameObject plank;
    public GameObject sapling;
    public GameObject chicken;
    public GameObject egg;
    public GameObject goldenEgg;
    public GameObject meat;
    public GameObject lamb;

    private GameObject machine;

    private void Start()
    {
        machine = GameObject.FindGameObjectWithTag("Machine");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "clothes")
        {
            Destroy(collision.gameObject);
            Instantiate(cloth, machine.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "cloth")
        {
            Destroy(collision.gameObject);
            Instantiate(wool, machine.transform.position, Quaternion.identity);
        }
        //////////////////////////////////////////////////////////
        else if (collision.gameObject.tag == "metal")
        {
            Destroy(collision.gameObject);
            Instantiate(metalPipe, machine.transform.position, Quaternion.identity);
        }
        //////////////////////////////////////////////////////////////////////
        else if (collision.gameObject.tag == "glassObject")
        {
            Destroy(collision.gameObject);
            Instantiate(glass, machine.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "glass")
        {
            Destroy(collision.gameObject);
            Instantiate(sand, machine.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "sand")
        {
            Destroy(collision.gameObject);
            Instantiate(stone, machine.transform.position, Quaternion.identity);
        }
        ///////////////////////////////////////////////////////////////////////
        else if (collision.gameObject.tag == "chair")
        {
            Destroy(collision.gameObject);
            Instantiate(plank, machine.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "plank")
        {
            Destroy(collision.gameObject);
            Instantiate(sapling, machine.transform.position, Quaternion.identity);
        }
        ///////////////////////////////////////////////////////////////////////
        else if (collision.gameObject.tag == "chciken")
        {
            Destroy(collision.gameObject);
            Instantiate(egg, machine.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "egg")
        {
            Destroy(collision.gameObject);
            Instantiate(chicken, machine.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "chciken")
        {
            Destroy(collision.gameObject);
            Instantiate(egg, machine.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "egg")
        {
            Destroy(collision.gameObject);
            Instantiate(chicken, machine.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "chciken")
        {
            Destroy(collision.gameObject);
            Instantiate(egg, machine.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "egg")
        {
            Destroy(collision.gameObject);
            Instantiate(chicken, machine.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "chciken")
        {
            Destroy(collision.gameObject);
            Instantiate(egg, machine.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "egg")
        {
            Destroy(collision.gameObject);
            Instantiate(chicken, machine.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "chicken")
        {
            Destroy(collision.gameObject);
            Instantiate(goldenEgg, machine.transform.position, Quaternion.identity);
        }
        ///////////////////////////////////////////////////////////////////////////////////
        else if (collision.gameObject.tag == "meat")
        {
            Destroy(collision.gameObject);
            Instantiate(lamb, machine.transform.position, Quaternion.identity);
        }
    }

}