using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasControl : MonoBehaviour
{
   
    public PlayerControl script;
    private Animator anim;
    void Start()
    {
        script = FindObjectOfType<PlayerControl>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

      

        if(script.Idied == true)
        {
            anim.SetBool("IsDead", true);
        }
     
    }
}
