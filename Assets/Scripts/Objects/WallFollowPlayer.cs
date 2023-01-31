using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFollowPlayer : MonoBehaviour
{
    /*
        class WallFollowPlayer is create to:
        - make the wall follow player only when s/he reaches its boundaries
        - boundaries are make through the collider
    */
    [Header("References")]
    [SerializeField] GameObject wall;
    Vector3 target;
    [Header("Variables")]
    [SerializeField] float speed;


    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            target = new Vector3(other.transform.position.x, wall.transform.position.y, wall.transform.position.z);
            wall.transform.position = Vector3.MoveTowards(wall.transform.position, target, Time.deltaTime * speed);
        }
        
    }

}
