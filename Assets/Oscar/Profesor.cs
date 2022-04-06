using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Profesor : MonoBehaviour
{
    public float speed;
    private Animator anim;
    public bool GameStart = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !GameStart)
        {
            GameStart = true;
            speed = 5;
        }
        transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        transform.localScale = new Vector2(2, 2);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
