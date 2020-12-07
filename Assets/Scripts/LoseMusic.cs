using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseMusic : MonoBehaviour
{
    AudioSource loseMusic;

    // Start is called before the first frame update
    void Start()
    {
        loseMusic = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (RubyController.currentHealth == 0)
        {
            loseMusic.mute = false;
        }
        if (RubyController.currentHealth >= 1)
        {
            loseMusic.mute = true;
        }
    }
}
