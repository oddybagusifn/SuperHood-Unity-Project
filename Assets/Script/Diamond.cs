using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    [SerializeField] private AudioSource diamondSoundEffect;
    public SpriteRenderer diamondSr;
    public CircleCollider2D diamondCol;


    void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.tag.Equals ("PlayerCoin")){
            diamondSoundEffect.Play();
            print ("Diamond diambil");
            diamondSr.enabled = false;
            diamondCol.enabled = false;
            DiamondScore.hitungDiamond += 1;
        }  
    }
}