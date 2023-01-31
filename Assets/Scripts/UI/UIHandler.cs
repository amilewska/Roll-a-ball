using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIHandler : MonoBehaviour
{
    /*
        class UIHandler is create to buttons to:
        - start game
        - go back to main menu scene
        - go to the next level  
        - quit the game
    */


    //METHODS FOR LOADING LEVELS
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();

#else
Application.Quit();
#endif
    }
}
