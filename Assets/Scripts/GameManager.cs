using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    [Header("References")]
    public GameObject player;
    
    public int score = 0;
    public int allScore = 0;
    public int death = 0;
    public GameObject[] pickUps;

    public int levelNumber;

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
        pickUps = GameObject.FindGameObjectsWithTag("PickUp");

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            player = GameObject.Find("Sphere");
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
