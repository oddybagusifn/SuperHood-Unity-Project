using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDie : MonoBehaviour
{

    public gerak Gerak;

    public SpriteRenderer playerSr;

    public Animator anime;

    [SerializeField] private AudioSource dieSoundEffect;
 void OnCollisionEnter2D(Collision2D target){
    if (target.gameObject.tag == "Enemy"){
        
        Die();
    }
 }

 void Die(){


 }

 
}
