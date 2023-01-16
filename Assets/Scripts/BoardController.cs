using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{

    float verticalInput;
    float horizontalInput;
    [SerializeField] float speed = 0.1f;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.rotation.x > 20) transform.rotation = Quaternion.Euler(20,transform.rotation.y,transform.rotation.z);
        transform.Rotate(Vector3.right, verticalInput*speed);
        transform.Rotate(Vector3.back, horizontalInput*speed);
    }
}
