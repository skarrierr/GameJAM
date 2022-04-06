using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject Player;

    public float Menos = 7.32f;
    public float Mas = 34.66f;
    public bool change;
    public bool HavetoChange;
    public GameObject[] List1;
    public GameObject[] List2;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (this.transform.position.x <= Player.transform.position.x - Menos)
        {
            this.transform.position = new Vector3(Player.transform.position.x + Mas, this.transform.position.y, this.transform.position.z);
            change = !change;
        } 

        if (HavetoChange == true)
        {
            if (change)
            {
                for (int i = 0; i < List1.Length; i++)
                {
                    List1[i].SetActive(false);
                }
                for (int i = 0; i < List2.Length; i++)
                {
                    List2[i].SetActive(true);
                }
            }
            else
            {
                for (int i = 0; i < List1.Length; i++)
                {
                    List1[i].SetActive(true);
                }
                for (int i = 0; i < List2.Length; i++)
                {
                    List2[i].SetActive(false);
                }
            }
        }

    }
}
