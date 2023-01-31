using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndPoint : MonoBehaviour
{
    public int currentScene;
    public GameObject endPanel;
    public TextMeshProUGUI AllScoreText;
    public TextMeshProUGUI AllDeathText;

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
            //save gained score
            GameManager.instance.AddAllScores(GameManager.instance.score);
            //zero score
            GameManager.instance.score = 0;

            if (currentScene < 20)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

            if (currentScene == 20)
            {
                endPanel.SetActive(true);
                AllDeathText.text = "You died: " + GameManager.instance.death + " times";
                AllScoreText.text = "Gained glows: " + GameManager.instance.allScore;

            }
            
            if (currentScene > GameManager.instance.levelNumber)
            {
                GameManager.instance.levelNumber = currentScene;
                GameManager.instance.SaveLevelNumber();
            }
            
            
        }
    }
}
