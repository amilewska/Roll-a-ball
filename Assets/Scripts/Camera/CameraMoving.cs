using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    Vector3 offset = new Vector3(0,7,-7);
    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.LookAt(player.transform.position);
        transform.position = Vector3.Lerp(transform.position, offset, 0.001f);
    }
}
