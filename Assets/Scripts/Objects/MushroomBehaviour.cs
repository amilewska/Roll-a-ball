using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MushroomBehaviour : PowerUpBehaviour
{
    public override void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.transform.localScale.x < 0.7f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        transform.localScale = new Vector3(transform.localScale.x, 0.4f, transform.localScale.z);
        
    }
}
