using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CogText : MonoBehaviour
{
    public static int cogValue = 4;
    Text num;
    // Start is called before the first frame update
    void Start()
    {
        num = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        num.text = "Cogs: " + cogValue;
    }
}
