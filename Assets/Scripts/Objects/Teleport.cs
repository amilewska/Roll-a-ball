using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    /*
        class Teleport is create to:
        - moves instantly the object which is within his collider from this position to position of second Portal
    */

    [SerializeField] Transform secondPortal;
    

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = secondPortal.position + Vector3.up;
        other.attachedRigidbody.AddRelativeForce(-Vector3.right * Time.deltaTime, ForceMode.Impulse);
        other.attachedRigidbody.velocity = new Vector3(other.attachedRigidbody.velocity.x, -other.attachedRigidbody.velocity.y, other.attachedRigidbody.velocity.z);
    }
}
