using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Renderer playerRenderer;
    [SerializeField] private float speed = 150f;
    [SerializeField] private GameObject lightBulb;
    private float offset = 1.5f;
    [SerializeField] float intensity = 1.5f;



    float horizontalInput;
    float verticalInput;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        playerRenderer = gameObject.GetComponent<Renderer>();

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        /*speed = GameManager.instance.ballSpeed;
        GameManager.instance.LoadBallSpeed();*/

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

        rb.AddForce(verticalInput * speed * Time.fixedDeltaTime* Vector3.forward);

        rb.AddForce(horizontalInput * speed * Time.deltaTime * Vector3.right);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            //GameManager.instance.AddScore(1);
            ColorChange(intensity); //how to make dependent of pickups on the level

        }
    }

    private void ColorChange(float intensity)
    {
        var actualColor = playerRenderer.material.GetColor("_EmissionColor");
        var newColor = actualColor * intensity;
        playerRenderer.material.SetColor("_EmissionColor", newColor);
        
    }
}
