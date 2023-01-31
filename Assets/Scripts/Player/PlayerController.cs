using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("References")]
    Rigidbody rb;
    Renderer playerRenderer;
    [SerializeField] GameObject lightBulb;

    [Header("Preferences")]
    [SerializeField] float offset = 1.5f;
    [SerializeField] float intensity = 1.5f;

    [Header("Movement values")]
    [SerializeField] float speed;
    float horizontalInput;
    float verticalInput;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        playerRenderer = gameObject.GetComponent<Renderer>();
        
    }

    void FixedUpdate()
    {
        if (GameManager.instance != null) speed = GameManager.instance.ballSpeed;
        MovePlayer();
        MoveLamp();
    }

    void MoveLamp()
    {
        if(lightBulb!=null) lightBulb.transform.position = new Vector3(transform.position.x, transform.position.y + offset, transform.position.z);
    }
    void MovePlayer()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        rb.AddForce(verticalInput * speed * Time.fixedDeltaTime * Vector3.forward);

        rb.AddForce(horizontalInput * speed * Time.fixedDeltaTime * Vector3.right);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            GameManager.instance.AddScore(1);
            ColorChange(intensity); //how to make dependent of pickups on the level?

        }
    }

    private void ColorChange(float intensity)
    {
        Color actualColor = playerRenderer.material.GetColor("_EmissionColor");
        Color newColor = actualColor * intensity;
        playerRenderer.material.SetColor("_EmissionColor", newColor);
        
    }
}
