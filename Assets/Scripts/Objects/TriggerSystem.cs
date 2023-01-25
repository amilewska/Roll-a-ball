using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSystem : MonoBehaviour
{
    public float speed;
    public GameObject[] stalkers;
    public GameObject triggerExitLabirynth;
    public GameObject hiddenObstacles;
    public bool exitLab;
    public GameObject player;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        stalkers = GameObject.FindGameObjectsWithTag("Enemy");

    }

    private void Update()
    {
        if (exitLab)
        {
            stalkers[0].SetActive(true);
            stalkers[0].transform.position = new Vector3(3.5f, 0.5f, 1.8f);
            stalkers[1].transform.position = new Vector3(3.6f, 0.5f, -3.8f);
            stalkers[2].transform.position = new Vector3(-4.2f, 0.5f, 1.9f);
            FollowPlayer();
        }
    }
    

    public void FollowPlayer()
    {
        foreach (GameObject stalker in stalkers)
        {
            stalker.transform.LookAt(player.transform);
            stalker.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
