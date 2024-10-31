using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    [SerializeField] private AudioSource hitSoundEffect;
    [SerializeField] private AudioSource dieSoundEffect;
    Rigidbody2D rb;
    Vector3 jalan;
    public static int  health;
    public int maxHealth = 7;
    bool m_IsTrigger;
    public int spawnDelay = 2;
    public gerak Gerak;
    public SpriteRenderer playerSr;
    public Animator anime;
    bool hit, mati;
    public GameObject Player;
    public Transform respawnPoint;
    public Collider2D TilemapCollider2D;
    public Collider2D enabledCollider2D;
    public patrolEnemy patrol;
    public Collider2D WaterCollider2D;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
        health = maxHealth;
      
    }

    void update()
    {
        
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <=0)
        {
            StartCoroutine(Respawn());
        TilemapCollider2D.enabled=false;
        anime.Play("mati"); 
        dieSoundEffect.Play();
        Gerak.enabled=false;
        enabledCollider2D.enabled=true;
        WaterCollider2D.enabled=false;

    
            
        } else {
            hitSoundEffect.Play();
            anime.Play("hit");
        }

    }

    void FixedUpdate(){
        if (health > maxHealth){
            health = maxHealth;
        } 
        
    }   


    public IEnumerator Respawn()
    {
        yield return new WaitForSeconds(2f);
        Player.transform.position = respawnPoint.position;
        health = maxHealth;
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}
