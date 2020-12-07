using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMusic : MonoBehaviour
{
    AudioSource winMusic;

    // Start is called before the first frame update
    void Start()
    {
        winMusic = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (RobotCounter.scoreValue >= 5)
        {
            winMusic.mute = false;
        }
        if (RobotCounter.scoreValue <= 4)
        {
            winMusic.mute = true;
        }
    }
}
