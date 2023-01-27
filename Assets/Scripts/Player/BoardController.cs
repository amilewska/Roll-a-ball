using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    [Header("Movement values")]
    float verticalInput;
    float horizontalInput;
    [SerializeField] float speed;

    

    void FixedUpdate()
    {
        if(GameManager.instance!= null) speed = GameManager.instance.boardSpeed;
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.rotation.x > 20) transform.rotation = Quaternion.Euler(20,transform.rotation.y,transform.rotation.z);
        transform.Rotate(Vector3.right, verticalInput * speed * Time.fixedDeltaTime);
        transform.Rotate(Vector3.back, horizontalInput * speed * Time.fixedDeltaTime);
    }
}
