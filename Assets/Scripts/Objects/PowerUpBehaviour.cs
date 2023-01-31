using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehaviour : MonoBehaviour
{
    /*
        class PowerUpBehaviour is create to:
        - moves the object in circle
        - make the player bigger when s/he touches it
    */

    [SerializeField] float speed = 0.5f;
    [SerializeField] float rotation = 90;
    private void Update()
    {
       transform.Translate(Vector3.back * Time.deltaTime * speed);
       transform.Rotate(Vector3.up, Time.deltaTime * rotation);
        
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.localScale *= 2;
            Destroy(gameObject);
        }
        
    }
}
