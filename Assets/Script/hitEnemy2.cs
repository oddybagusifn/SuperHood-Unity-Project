using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hitEnemy2 : MonoBehaviour
{
    public EdgeCollider2D mesh;
    public Animator anime;
    Rigidbody2D rb;
    public patrolEnemy patrol;
    public EnemyDamage damage;
    public Collider2D col;
    public SpriteRenderer render;

    private void OnTriggerEnter2D(Collider2D mesh)
    {
        if(mesh.gameObject.tag == "hit")
        {
            anime.SetTrigger("deadEnemy");
            StartCoroutine(Destroy());
            damage.enabled=false;  
            col.enabled=false;
            patrol.enabled=false;
        }
    }

    public IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
