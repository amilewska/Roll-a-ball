using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallFollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject wall;
    [SerializeField] float speed;
    Vector3 target;


    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            target = new Vector3(other.transform.position.x, wall.transform.position.y, wall.transform.position.z);
            //wall.transform.position = new Vector3(other.transform.position.x, wall.transform.position.y, wall.transform.position.z);
            //wall.transform.Translate(new Vector3(other.transform.position.x, wall.transform.position.y, wall.transform.position.z) * Time.deltaTime * speed);
            wall.transform.position = Vector3.MoveTowards(wall.transform.position, target, Time.deltaTime * speed);
        }
        
    }

}
