using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    public Text winText;
    // Start is called before the first frame update
    void Start()
    {
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (RobotCounter.scoreValue >= 9)
        {
            winText.text = "You Win! Game Made by Derek Gilberti! Press R to Restart.";
        }
        if (RobotCounter.scoreValue <= 8)
        {
            winText.text = "";
        }
    }
}
