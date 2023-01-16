using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Renderer playerRenderer;
    [SerializeField] private float speed = 2.0f;
    [SerializeField] private GameObject lightBulb;
    private float offset = 1.5f;

    

    float horizontalInput;
    float verticalInput;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerRenderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        lightBulb.transform.position = new Vector3(transform.position.x, transform.position.y + offset, transform.position.z);
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
            //GameManager.instance.AddScore(1);
            ColorChange(1.5f); //how to make dependent of pickups on the level

        }
    }

    private void ColorChange(float intensity)
    {
        Debug.Log("Color change");

        var actualColor = playerRenderer.material.GetColor("_EmissionColor");
        var newColor = actualColor * intensity;
        playerRenderer.material.SetColor("_EmissionColor", newColor);
        


    }
}
