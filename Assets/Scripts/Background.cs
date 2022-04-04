using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject Player;

    public float Menos = 7.32f;
    public float Mas = 34.66f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x <= Player.transform.position.x - Menos)
        {
            this.transform.position = new Vector3(Player.transform.position.x + Mas, this.transform.position.y, this.transform.position.z);
        } 
    }
}
