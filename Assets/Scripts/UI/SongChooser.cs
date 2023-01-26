using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SongChooser : MonoBehaviour
{
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
        }

        if (val == 3)
        {
            audiosource.clip = utopiaCosmicTrance;
        }

        if (val == 4)
        {
            audiosource.clip = space;
        }

        if (val == 5)
        {
            audiosource.clip = lifeLike;
        }

        audiosource.Play();
    }
}
