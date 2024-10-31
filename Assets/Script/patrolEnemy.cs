using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolEnemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public float kecepatanGerak;
    public bool berbalik;
    public Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        berbalik = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (berbalik)
        {
            rb.velocity = new Vector2(kecepatanGerak, rb.velocity.y);
            transform.rotation = Quaternion.Euler(0f, 165f, 0f);
        }
        else
        {
            rb.velocity = new Vector2(-kecepatanGerak, rb.velocity.y);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerCoin"))
        {
            berbalik = !berbalik;
            
        }
        
        
    }
    
}
