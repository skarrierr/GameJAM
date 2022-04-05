using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] Objects;

    private float tiempo = 0;

    private int RandomNumb;

    private void FixedUpdate()
    {
        tiempo += Time.deltaTime;


        if (tiempo>=2)
        {
            RandomNumb = Random.Range(0,Objects.Length);
            for (int i = 0; i < Objects.Length; i++)
            {
                if (i == RandomNumb)
                {
                     Instantiate(Objects[i], new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.Euler(0,0,0));
                }
            }
            tiempo = 0;
        }
    }
}
