using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    //public Button[] lvlButton;
    public GameObject lockPanel;
    public bool unlocked;
    public int levelIndex;

    private void Start()
    {
        if (GameManager.instance.levelNumber >= levelIndex) unlocked = true;

        if (!unlocked)
        {
            lockPanel.SetActive(true);
        }
        else
        {
            lockPanel.SetActive(false);

        }

        /*int levelAt = PlayerPrefs.GetInt("levelAt", 1);
        for (int i = 0; i < lvlButton.Length; i++)
        {
            if (i + 1 > levelAt)
            {
                lockPanel.SetActive(false);
                lvlButton[i].interactable = false;
            }
        }*/
    }
    public void LoadLevel()
    {
        if (unlocked) SceneManager.LoadScene("Level " + levelIndex);

    }
}
