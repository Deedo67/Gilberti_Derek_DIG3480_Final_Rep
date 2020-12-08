using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    public AudioClip speedSound;
    [SerializeField]
    Animator animation;
    [SerializeField]
    private float timer;

    void OnTriggerEnter2D(Collider2D other)
    {

        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            AudioSource.PlayClipAtPoint(speedSound, transform.position);
            animation.SetBool("Active", true);
            StartCoroutine(TrapIdle());
        }
    }

    IEnumerator TrapIdle()
    {
        yield return new WaitForSeconds(timer);
        animation.SetBool("Active", false);
    }
}
