using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public GameObject player;

    public int score = 0;
    public int death = 0;
    [SerializeField]public GameObject[] pickUps;

    public int levelNumber;

    [SerializeField] private Slider volumeSlider;

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
        LoadVolume();
    }
    

    private void Update()
    {
        pickUps = GameObject.FindGameObjectsWithTag("PickUp");



        if (SceneManager.GetActiveScene().buildIndex > 0)
        {
            player = GameObject.Find("Player");
            if (player.transform.position.y < -10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                score = 0;
            }

            if (pickUps.Length==score)
            {
                
                score = 0;
            }
        }
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
        
    }

    public void AddDeath(int value)
    {
        death += value;
        Debug.Log("Death: " + death);

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

    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("volumePref", volumeSlider.value);
        LoadVolume();
    }
    public void LoadVolume()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volumePref", 0.5f);
        AudioListener.volume = PlayerPrefs.GetFloat("volumePref", 0.5f);
    }

}
