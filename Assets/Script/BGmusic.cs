using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class BGmusic : MonoBehaviour
{
    public static BGmusic instance { get; set;}

    public AudioClip[] clipMusik;
    public AudioSource audioMusik;


 
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
             Destroy(gameObject);
        }
    }


    public void changeMusik(int indexMusik)
    {
        if(audioMusik.clip != clipMusik[indexMusik])
        {
            audioMusik.Stop();
            audioMusik.clip = clipMusik[indexMusik];
            audioMusik.Play();
        }
    }

    public void MusikStop()
    {
        audioMusik.Stop();
    }
}