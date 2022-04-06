using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public float fuerzasalto;
    public BoxCollider2D Collider;
    public BoxCollider2D Collider2;
    private Animator anim;
    public LayerMask CapaSuelo;
    public bool GameStart = false;
    public bool Idied = false;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !GameStart)
        {
            GameStart = true;
            speed = 10;
            anim.SetBool("IsRunning", true);

        }


        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded())
        {
            anim.SetBool("IsJumping", true);
            rb.AddForce(Vector2.up * fuerzasalto, ForceMode2D.Impulse);
        }
        else
        {
            anim.SetBool("IsJumping", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {   
            Collider.enabled = false;
            Collider2.enabled = true;
            anim.SetBool("Deslizarse", true); 
          
        }
        else
        {
            Collider.enabled = true;
            Collider2.enabled = false;
            anim.SetBool("Deslizarse", false);
        
        }
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        
    }
    bool IsGrounded()
    {
        RaycastHit2D raycasthit = Physics2D.BoxCast(Collider.bounds.center, new Vector2(Collider.bounds.size.x, Collider.bounds.size.y), 0f, Vector2.down, 0.2f, CapaSuelo);
        return raycasthit.collider != null;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            speed = 0;
            anim.SetBool("IsDeath", true);
            Idied = true;
            SceneManager.LoadScene("Menu");
        }
    }


}

