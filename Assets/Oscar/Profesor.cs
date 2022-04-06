using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Profesor : MonoBehaviour
{
    public float speed;
    public bool GameStart = false;
    private SoundManager soundManager;

    private void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !GameStart)
        {
            soundManager.Seleccion(0, 0.5f);
            GameStart = true;
            speed = 5;
            soundManager.Seleccion(1, 0.5f);
        }
        transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        transform.localScale = new Vector2(2, 2);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            soundManager.Seleccion(2, 0.5f);
            SceneManager.LoadScene("Menu");
        }
    }
}
