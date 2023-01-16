using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    
    public int currentScene;
    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        GameManager.instance.levelNumber = currentScene;
        GameManager.instance.SaveLevelNumber();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            if(currentScene > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", currentScene);
            }

            if (currentScene > GameManager.instance.levelNumber)
            {
                GameManager.instance.levelNumber = currentScene;
                GameManager.instance.SaveLevelNumber();

            }

            
        }
    }
}
