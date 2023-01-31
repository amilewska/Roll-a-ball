using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatBehavioour : MonoBehaviour
{
    /*
        class HatBehavioour is create to:
        - moves the hat when player is moving too
    */

    [SerializeField] GameObject player;
    float offset = 0.17f;
   
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + offset, player.transform.position.z);
        
    }
}
