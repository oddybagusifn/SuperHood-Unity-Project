using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm : MonoBehaviour
{
    public BoxCollider2D musicCol;
    [SerializeField] AudioSource backgroundmusic;

    void OnCollisionEnter2D(Collision2D col){
         if (col.gameObject.tag.Equals ("PlayerCoin")){
            print ("Musik Nyala");
            backgroundmusic.Play();
         }
    }
}
