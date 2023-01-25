using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExitLabirynth : FirstTrigger
{
    
    private void OnTriggerExit(Collider other)
    {
        if(gameObject.tag == "Player")
        {
            hiddenObstacles.SetActive(false);
            exitLab = true;
        }
        
    }
}
