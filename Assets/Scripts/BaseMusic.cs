using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMusic : MonoBehaviour
{
    AudioSource backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        backgroundMusic.mute = false;

        if (RobotCounter.scoreValue >= 9)
        {
            backgroundMusic.mute = true;
        }
        
        if (RubyController.currentHealth == 0)
        {
            backgroundMusic.mute = true;
        }
    }
}