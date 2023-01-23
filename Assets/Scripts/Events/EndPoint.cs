using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    public int currentScene;
    public GameObject endPanel;

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
            if (currentScene == 13)
            {
                endPanel.SetActive(true);
            }
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
