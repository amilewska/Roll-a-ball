using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed = 2.0f;
    [SerializeField] private GameObject lightBulb;
    private float offset= 1.6f;

    float horizontalInput;
    float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        lightBulb.transform.position = new Vector3(transform.position.x, transform.position.y+offset, transform.position.z);
        
    }

    void MovePlayer()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        rb.AddForce(verticalInput * speed * Vector3.forward);
        rb.AddForce(horizontalInput * speed * Vector3.right);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            GameManager.instance.AddScore(1);
        }
    }
}
