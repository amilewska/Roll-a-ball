using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    
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

    }
    public void LoadLevel()
    {
        if (unlocked) SceneManager.LoadScene("Level " + levelIndex);

    }
}
