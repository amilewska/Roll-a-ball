using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    /*
        class CameraMoving is create to:
        - move the camera to more smooth effect
    */
    public GameObject player;
    Vector3 endPos = new Vector3(0, 7,-7);

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, endPos, 0.001f);
    }
}
