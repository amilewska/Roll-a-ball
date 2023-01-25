using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTrigger : TriggerSystem
{

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //stalker.transform.position = Vector3.MoveTowards(stalker.transform.position, other.transform.position, Time.deltaTime * speed);
            FollowPlayer();

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            hiddenObstacles.SetActive(true);
        }
    }
}
