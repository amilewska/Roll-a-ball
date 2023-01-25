using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongChooser : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip spacechillout;
    public AudioClip abstracionPop;
    public AudioClip cosmicTrance;
    public AudioClip utopiaCosmicTrance;
    public AudioClip space;
    public AudioClip lifeLike;
    
    // Start is called before the first frame update
    public void ChooseSong(int val)
    {
        if (val == 0)
        {
            audiosource.clip = spacechillout;
        }

        if (val == 1)
        {
            audiosource.clip = abstracionPop;
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
