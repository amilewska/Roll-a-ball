using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExitLabirynth : FirstTrigger
{
    /*
        class TriggerExitLabirynth is create to:
        - hidden labirynth when player leaves it
    */

    private void OnTriggerExit(Collider other)
    {
        if(gameObject.tag == "Player")
        {
            hiddenObstacles.SetActive(false);
            exitLab = true;
        }
        
    }
}
