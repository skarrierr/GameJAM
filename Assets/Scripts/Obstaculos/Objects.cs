using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    private void Start()
    {
        Destroy(this.gameObject, 5);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Profesor"))
        {
            Destroy(gameObject);
        }
    }


    private void FixedUpdate()
    {
        
    }
}
