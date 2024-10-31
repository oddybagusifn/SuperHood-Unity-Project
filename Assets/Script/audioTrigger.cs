using UnityEngine;
using System.Collections;

public class audioTrigger : MonoBehaviour 
{

    private AudioSource audioSource;

    void OnTriggerEnter2D(Collider2D collider) 
    {

        if(collider.tag == "PlayerCoin") 
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }
    }
}