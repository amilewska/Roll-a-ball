using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    [SerializeField]private GameObject[] pickUps;

    int score;
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

        pickUps = GameObject.FindGameObjectsWithTag("PickUp");
        Debug.Log("score:" + score +"pickups " + pickUps.Length);
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
