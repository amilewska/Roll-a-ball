using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikesHarm : MonoBehaviour
{
    /*
        class SpikesHarm is create to (when player collides with it):
        - load the same level 
        - add death to the Game Manager
        - reset score
        - unactive other object with tag Enemy
    */

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(LoadLevel());
            GameManager.instance.AddDeath(1);
            GameManager.instance.score = 0;

        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
        }
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
