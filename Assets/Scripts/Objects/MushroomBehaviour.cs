using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MushroomBehaviour : PowerUpBehaviour
{
    /*
        class MushroomBehaviour is create to:
        - moves the object in circle (inherit from PowerUpBehaviour)
        - make vulnerable to the bigger objects
        - flatten when bigger object touch it
    */

    float minHeightToKill = 0.7f;
    float heightFlatY = 0.4f;

    public override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.localScale.x < minHeightToKill)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            GameManager.instance.score = 0;
        }

        transform.localScale = new Vector3(transform.localScale.x, heightFlatY, transform.localScale.z);
        
    }
}
