using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExit : MonoBehaviour
{
    /*
        class TriggerExit is create to:
        - moves the exit when player is near to it
    */

    [SerializeField]GameObject exit;
    [SerializeField]Transform endPos;
    bool isExit = false;

    private void Update()
    {
        if(isExit) exit.transform.position = Vector3.Lerp(exit.transform.position, endPos.position, Time.deltaTime * 2);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isExit = true;
        }
    }
}
