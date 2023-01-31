using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class GameManager : MonoBehaviour
{
    /*
        class GameManager is create to:
        - save score, total score, number of deaths, unblocked current level,
        - reload the level when player is far from board (when player is on the levels)
        - transform position of the player when player is far from board (when player is on the Main Menu)
        - being reference to others scripts
    */
    public static GameManager instance { get; private set; }

    [Header("References")]
    public GameObject player = null;

    [Header("Scores values")]
    public int score = 0;
    public int allScore = 0;
    public int death = 0;

    [Header("Amount of unblocked levels")]
    public int levelNumber;

    [Header("Speed values")]
    public float ballSpeed;
    public float boardSpeed;

    private void Awake()
    {
        if(instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        LoadLevelNumber();
        
    }


    private void Update()
    {
        
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            player = GameObject.Find("Sphere");

            if (player!=null && player.transform.position.y < -10)
            {
                
                player.GetComponent<Rigidbody>().velocity = Vector3.zero;
                player.transform.position = new Vector3(0, 10, 0);
                
            }
                
        }



        if (SceneManager.GetActiveScene().buildIndex > 0)
        {
            player = GameObject.Find("Player");
            if (player.transform.position.y < -10)
            {
                AddDeath(1);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                score = 0;
            }

            
        }
    }

    public void AddScore(int value)
    {
        score += value;
    }

    public void AddAllScores(int value)
    {
        allScore += value;
    }

    public void AddDeath(int value)
    {
        death += value;
    }

    [System.Serializable]
    class SaveData
    {
        public int levelNumber;
    }

    public void SaveLevelNumber()
    {
        SaveData data = new SaveData();
        data.levelNumber = levelNumber;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadLevelNumber()
    {
        string path = Application.persistentDataPath + "savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            levelNumber = data.levelNumber;
        }

    }

}
