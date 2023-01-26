using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    [Header("Volume Setting")]
    [SerializeField] Slider volumeSlider;

    [Header("Speed Settings")]
    [SerializeField] Slider speedBallSlider;
    [SerializeField] TextMeshProUGUI speedBallText;
    [SerializeField] Slider speedBoardSlider;
    [SerializeField] TextMeshProUGUI speedBoardText;

    private void Awake()
    {
        LoadVolume();

        LoadBallSpeed();
        LoadBoardSpeed();
        DontDestroyOnLoad(gameObject);

    }

    


    //VOLUME SETTINGS

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
    
    //BOARD SETTINGS

    public void SaveBoardSpeed()
    {
        PlayerPrefs.SetFloat("speedBoard", speedBoardSlider.value);
        LoadBoardSpeed();
    }

    public void LoadBoardSpeed()
    {
        speedBoardSlider.value = PlayerPrefs.GetFloat("speedBoard", 0.2f);
        GameManager.instance.boardSpeed = PlayerPrefs.GetFloat("speedBoard", 0.2f);
        speedBoardText.text = GameManager.instance.boardSpeed.ToString("0");
        
    }

    //BALL SETTINGS
    public void SaveBallSpeed()
    {
        PlayerPrefs.SetFloat("speedBall", speedBallSlider.value);
        LoadBallSpeed();
    }

    public void LoadBallSpeed()
    {
        speedBallSlider.value = PlayerPrefs.GetFloat("speedBall", 0.4f);
        GameManager.instance.ballSpeed = PlayerPrefs.GetFloat("speedBall", 0.4f);
        speedBallText.text = GameManager.instance.ballSpeed.ToString("0");
    }

    //DEFAULT SETTINGS

    public void DefaultValue()
    {
        speedBallSlider.value = 200;
        PlayerPrefs.SetFloat("speedBall", speedBallSlider.value);
        LoadBallSpeed();

        speedBoardSlider.value = 20;
        PlayerPrefs.SetFloat("speedBoard", speedBoardSlider.value);
        LoadBoardSpeed();
    }

}
