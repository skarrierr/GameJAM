using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip[] audios;
    private AudioSource control;

    private void Awake()
    {
        control = GetComponent<AudioSource>();
    }

    public void Seleccion(int indice, float volumen)
    {
        control.PlayOneShot(audios[indice], volumen);
    }
}
