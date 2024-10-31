using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicControl : MonoBehaviour
{
public static musicControl Instance { get; set;}

    public AudioClip[] clipMusic;
    public AudioSource audioMusic;

    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        if( musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

}

