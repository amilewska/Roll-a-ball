using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPauseMenu : MonoBehaviour
{
    public GameObject pauseScreen;
    public bool isPaused=true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused) ActivePauseMenu();
        else DeactivePauseMenu();
    }

    private void ActivePauseMenu()
    {
        isPaused = true;
        Time.timeScale = 0;
        pauseScreen.SetActive(true);

    }

    public void DeactivePauseMenu()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }

}
