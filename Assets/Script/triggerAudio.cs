using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAudio : MonoBehaviour
{
    public AudioSource sfx;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Player")
        {
            sfx.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.name == "Player")
        {
            sfx.Stop();
        }
    }
}
