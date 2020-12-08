using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public AudioClip speedSound;

    void OnTriggerEnter2D(Collider2D other)
    {

        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            AudioSource.PlayClipAtPoint(speedSound, transform.position);
            Destroy(gameObject);
        }
    }
}
