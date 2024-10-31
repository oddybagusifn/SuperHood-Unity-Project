using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{    
    public SpriteRenderer coinSr;
    public CircleCollider2D coinCol;
    [SerializeField] private AudioSource coinSoundEffect;


    void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.tag.Equals ("PlayerCoin")){
            print ("Coin diambil");
            coinSoundEffect.Play();
            coinSr.enabled = false;
            coinCol.enabled = false;
            CoinScore.hitungCoin += 50;
        }  
            
        
    }
}
