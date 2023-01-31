using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SongChooser : MonoBehaviour
{
    /*
        class SongChooser is create to:
        - save clips
        - play the clips
        - change the label on dropdown
    */

    [Header("Audiosource")]
    public AudioSource audiosource;

    [Header("Audioclips")]
    public AudioClip spacechillout;
    public AudioClip abstracionPop;
    public AudioClip cosmicTrance;
    public AudioClip utopiaCosmicTrance;
    public AudioClip space;
    public AudioClip lifeLike;
    public TextMeshProUGUI labelText;

    private void Update()
    {
        audiosource = GameManager.instance.GetComponent<AudioSource>();
    }

    
    public void ChooseSong(int val)
    {
        if (val == 0)
        {
            audiosource.clip = spacechillout;
            labelText.text = "Space Chillout";
        }

        if (val == 1)
        {
            audiosource.clip = abstracionPop;
            labelText.text = "Abstaction Pop";
        }

        if (val == 2)
        {
            audiosource.clip = cosmicTrance;
            labelText.text = "Cosmic Trance";
        }

        if (val == 3)
        {
            audiosource.clip = utopiaCosmicTrance;
            labelText.text = "Utopia Cosmic";
        }

        if (val == 4)
        {
            audiosource.clip = space;
            labelText.text = "Space";
        }

        if (val == 5)
        {
            audiosource.clip = lifeLike;
            labelText.text = "Lifelike";
        }

        audiosource.Play();
    }
}
