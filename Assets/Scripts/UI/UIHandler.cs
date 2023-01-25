using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIHandler : MonoBehaviour
{
    //SETTINGS
    //volume
    [SerializeField] private Slider volumeSlider;
    //speed
    [SerializeField] Slider speedBallSlider;
    [SerializeField] TextMeshProUGUI speedBallText;
    [SerializeField] Slider speedBoardSlider;
    [SerializeField] TextMeshProUGUI speedBoardText;

    
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

    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("volumePref", volumeSlider.value);
        LoadVolume();
    }
    public void LoadVolume()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volumePref", 0.2f);
        AudioListener.volume = PlayerPrefs.GetFloat("volumePref", 0.2f);
    }
    
    public void SaveBoardSpeed()
    {
        PlayerPrefs.SetFloat("speedBoard", speedBoardSlider.value);
        LoadBoardSpeed();
    }

    public void LoadBoardSpeed()
    {
        speedBoardSlider.value = PlayerPrefs.GetFloat("speedBoard", 0.2f);
        GameManager.instance.boardSpeed = PlayerPrefs.GetFloat("speedBoard", 0.2f);
        GameManager.instance.boardSpeed *= 8 * 12.5f;
    }

    public void ShowValueSpeed()
    {
        speedBoardText.text = GameManager.instance.boardSpeed.ToString("0");

    }


    public void SaveBallSpeed()
    {
        PlayerPrefs.SetFloat("speedBall", speedBallSlider.value);
        LoadBallSpeed();
    }

    public void LoadBallSpeed()
    {
        speedBallSlider.value = PlayerPrefs.GetFloat("speedBall", 0.4f);
        GameManager.instance.ballSpeed = PlayerPrefs.GetFloat("speedBall", 0.4f);
        GameManager.instance.ballSpeed *= 1000;
    }

    public void ShowValueBallSpeed()
    {
        speedBallText.text = GameManager.instance.ballSpeed.ToString("0");

    }

    public void DefaultValue()
    {
        GameManager.instance.ballSpeed = 150;
        GameManager.instance.boardSpeed = 8;
    }

}
