using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    public GameObject player;
    int score=0;
    [SerializeField]private GameObject[] pickUps;

    private void Awake()
    {
        if(instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    
    private void Update()
    {
        pickUps = GameObject.FindGameObjectsWithTag("PickUp");
        Debug.Log("score:" + score +"pickups " + pickUps.Length);
        

        if (SceneManager.GetActiveScene().buildIndex > 0)
        {
            player = GameObject.Find("Player");
            if (player.transform.position.y < -10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                score = 0;
            }

            if (pickUps.Length==0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                score = 0;
            }
        }
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);

    }
}
