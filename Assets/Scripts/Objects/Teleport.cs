using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]Transform secondPortal;
    

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = secondPortal.position + Vector3.up;
        other.attachedRigidbody.AddRelativeForce(-Vector3.right * Time.deltaTime, ForceMode.Impulse);
        other.attachedRigidbody.velocity = new Vector3(other.attachedRigidbody.velocity.x, -other.attachedRigidbody.velocity.y, other.attachedRigidbody.velocity.z);
    }
}
