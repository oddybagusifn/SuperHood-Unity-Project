using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class punchItem : MonoBehaviour
{
    public SpriteRenderer punchSr;
    public Collider2D punchCol;
    [SerializeField] private AudioSource punchSoundEffect;
    public GameObject punch;
    public GameObject notification;

    void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.tag.Equals("PlayerCoin")){
            print ("Punch diambil");
            punchSoundEffect.Play();
            punchSr.enabled = false;
            punchCol.enabled = false;
            punch.SetActive(true);
            StartCoroutine(notif());
            notification.SetActive(true);
        }  
    }

    public IEnumerator notif()
    {
        yield return new WaitForSeconds(5f);
        notification.SetActive(false);
    }

    
}


