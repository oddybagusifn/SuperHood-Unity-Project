using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hitEnemy : MonoBehaviour
{
    public Collider2D mesh;
    public EdgeCollider2D mesh2;
    public Animator anime;
    Rigidbody2D rb;
    public patrolEnemy patrol;
    public EnemyDamage damage;
    public Collider2D col;
    public SpriteRenderer render;
    [SerializeField] AudioSource dieEnemy;
    

    private void OnTriggerEnter2D(Collider2D mesh)
    {
        if(mesh.gameObject.tag == "hit")
        {
            anime.SetTrigger("deadEnemy");
            StartCoroutine(Destroy());
            damage.enabled=false;  
            col.enabled=false;
            patrol.enabled=false;
            dieEnemy.Play();
            
            
        }
    }

    public IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1f);
    }
}
