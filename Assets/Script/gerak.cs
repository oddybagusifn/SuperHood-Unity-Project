using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.KeyCode;

public class gerak : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed, velX;
    Vector3 jalan;
    public Animator anime;
    //new
    public float jumpValue;
    bool hit, mati;
    
    [SerializeField] Transform groundCheckCollider;
    const float groundCheckRadius = 0.2f;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] private AudioSource jumpSoundEffect;
    [SerializeField] bool isGrounded = false;
    public bool IsMoving = false;
    [SerializeField] public AudioSource footstep;
    
    


    public void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(IsMoving)
        {
            if(!footstep.isPlaying)
            footstep.Play();
        }

        if(!IsMoving)
        {
            if(footstep.isPlaying)
            footstep.Stop();
        }

        if(!isGrounded)
        {
            footstep.Stop();
        }
        
        jalan.x = Input.GetAxisRaw("Horizontal");
        
        transform.position += jalan * speed * Time.deltaTime;
        
        if(jalan != Vector3.zero)
        {
            anime.SetBool("lari",true);
            anime.SetBool ("lompat", false);
        } 
        else
            anime.SetBool("lari",false);
            IsMoving = false;
        if (jalan == Vector3.left)
        {
            anime.SetBool("lari",true);
            anime.SetBool ("lompat", false);
            transform.rotation = Quaternion.Euler (0, 165, 0);
            IsMoving = true;
        } 
        else if (jalan == Vector3.right){
            transform.rotation = Quaternion.Euler (0, 0, 0);
            IsMoving = true;
        }


        if (Input.GetButtonDown ("Jump") && rb.velocity.y == 0)
        {
        jumpSoundEffect.Play();
        rb.AddForce (new Vector2(0, jumpValue));
        }
        

        AnimationState();

        if(!mati)
        velX = Input.GetAxisRaw ("Horizontal") * speed;

    }
    

    void FixedUpdate()
    {
        if(!hit)
        GroundCheck();
        rb.velocity = new Vector2 (velX, rb.velocity.y);
        
    }

    void GroundCheck()
    {
        isGrounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckCollider.position, groundCheckRadius, groundLayer);
        if(colliders.Length>0)
        isGrounded = true;
    }
    void AnimationState()
    {
        if (rb.velocity.y == 00){
            anime.SetBool ("lompat", false);
            anime.SetBool ("jatuh", false);
            
        }
        if(rb.velocity.y > 0){
            anime.SetBool ("lompat", true);
            anime.SetBool ("jatuh", false);
        }
            
            

        if (rb.velocity.y < 0){
            anime.SetBool ("lompat", false);
            anime.SetBool ("jatuh", true);
        }

        if (isGrounded == true)
        {
            anime.SetBool ("jatuh", false);
            anime.SetBool ("lompat", false);
        }
    }

    
}
