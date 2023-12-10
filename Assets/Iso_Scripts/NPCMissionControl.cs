using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCMissionControl : MonoBehaviour
{
    public bool npcMission;
    public GameObject sand;

    private void Start()
    {
        npcMission = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "sand")
        {
            npcMission = true;
            Destroy(collision.gameObject);
            Debug.Log("Good Ending");
            SceneManager.LoadScene("GoodEndingScene");

        }
        else if (collision.gameObject.tag == "stone")
        {
            npcMission = true;
            Destroy(collision.gameObject);
            Debug.Log("Bad Ending");
            SceneManager.LoadScene("BadEndingScene");

        }
    }
}

