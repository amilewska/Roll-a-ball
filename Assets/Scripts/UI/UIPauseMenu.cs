using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIPauseMenu : MonoBehaviour
{
    public GameObject pauseScreen;
    public bool isPaused=true;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI deathText;
    public GameObject[] glowsOnThisLevel;

    private void Start()
    {
        glowsOnThisLevel = GameObject.FindGameObjectsWithTag("PickUp");
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            
        }

        if (isPaused) ActivePauseMenu();
        else DeactivePauseMenu();
    }

    public void ActivePauseMenu()
    {
        isPaused = true;
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
        deathText.text = "Deaths: " + GameManager.instance.death;
        scoreText.text = "Glows: " + GameManager.instance.score + "/"+ glowsOnThisLevel.Length;

    }

    public void DeactivePauseMenu()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }

}
