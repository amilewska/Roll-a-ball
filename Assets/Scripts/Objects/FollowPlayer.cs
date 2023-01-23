using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    [SerializeField] float speed;
    [SerializeField] GameObject[] stalkers;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //stalker.transform.position = Vector3.MoveTowards(stalker.transform.position, other.transform.position, Time.deltaTime * speed);
            foreach (var stalker in stalkers)
            {
                stalker.transform.LookAt(other.transform);
                stalker.transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
            
        }

    }
}
