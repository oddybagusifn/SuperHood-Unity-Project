using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addForce : MonoBehaviour
{
public EdgeCollider2D Ecol2;

void Start()
{
    Ecol2.enabled = false;
}

public void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.tag == "Enemy")
    {
        Ecol2.enabled = true;
    } 
}


}
