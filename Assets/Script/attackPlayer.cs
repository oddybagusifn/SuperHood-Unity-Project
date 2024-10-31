using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attackPlayer : MonoBehaviour
{
    public Collider2D col;
    public Animator anime;
    public Animator anime1;
    [SerializeField] AudioSource punch;

    void Start()
    {
        anime1.SetBool("mukul" ,false);
    }

    
    void Update()
    {
        if (Input.GetButtonDown ("Fire1"))
        {
            anime.SetBool("Punch" ,true);
            anime1.SetBool("mukul" ,true);
            col.enabled = true;
            StartCoroutine(Disabled());
            punch.Play();

        } else {
            anime.SetBool("Punch" ,false);
            anime1.SetBool("mukul", false);
        }
        
    }

    public IEnumerator Disabled()
    {
        yield return new WaitForSeconds(0.2f);
        col.enabled = false;
    }
}
