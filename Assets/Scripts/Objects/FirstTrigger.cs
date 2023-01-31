using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTrigger : TriggerSystem
{
    /*
        class FirstTrigger is create to:
        - make the stalkers (white spheres) follow player when it leaves pick up trap
        - show the hidden labirynth when player exit the pick up trap
    */

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
