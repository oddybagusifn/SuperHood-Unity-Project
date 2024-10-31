using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerCollider : MonoBehaviour
{
    public BoxCollider2D col;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PlayerCoin")
        {
            col.enabled = false;
        }
    }
}
