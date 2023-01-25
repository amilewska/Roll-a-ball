using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]Transform secondPortal;
    

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = secondPortal.position;
        other.attachedRigidbody.AddRelativeForce(Vector3.right*Time.deltaTime);
    }
}
