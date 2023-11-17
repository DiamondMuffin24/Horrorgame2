using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Off : MonoBehaviour
{
    public AudioClip FlashLight_On;
    public AudioClip FlashLight_Off;

    private AudioSource audioSource;
    private bool isKeyPressed = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Replace "KeyCode.Space" with the key you want to use
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!isKeyPressed)
            {
                // Key pressed for the first time, play the first sound
                audioSource.clip = FlashLight_On;
                audioSource.Play();
                isKeyPressed = true;
            }
            else
            {
                // Key pressed for the second time, play the second sound
                audioSource.clip = FlashLight_Off;
                audioSource.Play();
                isKeyPressed = false;
            }
        }
    }
}