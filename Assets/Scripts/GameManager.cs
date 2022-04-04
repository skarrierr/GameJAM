using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text Scoretxt;
    public Text Cointxt;

    public int Score;
    public int Coin;
    public bool pillado; 


   

    private void FixedUpdate()
    {
       if (!pillado){ 
           Score++;
           Scoretxt.text = Score.ToString();
       }
    }
}

