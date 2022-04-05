using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Profesor : MonoBehaviour
{
    public float walkSpeed;
    [HideInInspector]
    public bool mustPatrol;
    public bool MoveRight;
    public float HP = 4;
    public float knockbackPower = 100;
    public float knockbackDuration = 1;

    public void TakeDamage(float damage)
    {
        HP -= damage;
    }

    // Update is called once per frame
    void Update()
    {
        Patrullar();

        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Ground"))
        {
            if (MoveRight)
            {
                MoveRight = false;
            }
            else
            {
                MoveRight = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("CreditsOscar");
        }
    }

        private void Patrullar()
    {
        if (MoveRight)
        {
            transform.Translate(2 * Time.deltaTime * walkSpeed, 0, 0);
            transform.localScale = new Vector2(2, 2);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * walkSpeed, 0, 0);
            transform.localScale = new Vector2(-2, 2);
        }
    }

    private void Perseguir()
    {

    }
}
