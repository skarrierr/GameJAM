using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public float fuerzasalto;
    public BoxCollider2D Collider;
    public BoxCollider2D Collider2;
    private Animator anim;
    public LayerMask CapaSuelo;
    public GameObject Sprite_Desliz;
    private SpriteRenderer sr;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
   
      anim = GetComponent<Animator>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded())
        {
            rb.AddForce(Vector2.up * fuerzasalto, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {   
            Collider.enabled = false;
            Collider2.enabled = true;
            // anim.SetBool("Deslizarse", true); 
            Sprite_Desliz.SetActive(true);
            sr.enabled = false;
        }
        else
        {
            Collider.enabled = true;
            Collider2.enabled = false;
            // anim.SetBool("Deslizarse", false);
            Sprite_Desliz.SetActive(false);
            sr.enabled = true;
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

}

