using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogCollectable : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.ChangeCog(+4);
            CogText.cogValue = CogText.cogValue + 4;
            Destroy(gameObject);
        }
    }
}
