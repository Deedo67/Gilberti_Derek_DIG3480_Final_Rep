using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseScript : MonoBehaviour
{
    public Text loseText;
    // Start is called before the first frame update
    void Start()
    {
        loseText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (RubyController.currentHealth == 0)
        {
            loseText.text = "You lose! Press R to Restart.";
        }
        if (RubyController.currentHealth >= 1)
        {
            loseText.text = "";
        }
    }
}
