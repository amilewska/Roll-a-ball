using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndPoint : MonoBehaviour
{
    /*
        class EndPoint is create to:
        - end the level and move to the next one
        - save the actual level (through Game Manager) to unblock it in the main menu
        - show the end panel when game is ended
    */
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
            //clear score
            GameManager.instance.score = 0;

            //move to the next level when player has reached the green point
            if (currentScene < 20)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

            //show end panel on the last one with the total score
            if (currentScene == 20)
            {
                endPanel.SetActive(true);
                AllDeathText.text = "You died: " + GameManager.instance.death + " times";
                AllScoreText.text = "Gained glows: " + GameManager.instance.allScore;

            }
            
            //save the current level to the main menu to unblock it
            if (currentScene > GameManager.instance.levelNumber)
            {
                GameManager.instance.levelNumber = currentScene;
                GameManager.instance.SaveLevelNumber();
            }
            
            
        }
    }
}
