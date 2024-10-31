using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private AudioSource heartSoundEffect;
    public SpriteRenderer heartSr;
    public CircleCollider2D heartCol;
    public int healthValue;

    void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.tag.Equals ("PlayerCoin")){
            print ("Heal diambil");
            heartSoundEffect.Play();
            heartSr.enabled = false;
            heartCol.enabled = false;
            playerHealth.health += healthValue;
        }  
    }
}
