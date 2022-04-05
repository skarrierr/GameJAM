using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text Scoretxt;
    public Text start;
    public GameObject logo;
    public PlayerControl script;
    public int Score;
   
    public bool pillado = true;

    private void Start()
    {
        script = FindObjectOfType<PlayerControl>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            logo.SetActive(false);
               
            start.text = "";
        }
    }
    private void FixedUpdate()
    {
        if (script.speed != 0)
        {
            Score++;
           Scoretxt.text = Score.ToString();
       }
    }
}
       


