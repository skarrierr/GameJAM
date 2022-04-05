using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoRight : MonoBehaviour
{
    public float speed;
    public PlayerControl script;


    private void Start()
    {
        script = FindObjectOfType<PlayerControl>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = 10;
        }
    }
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (script.speed == 0) {
            speed = 0;
        }
    }
}
