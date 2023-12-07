using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spooky_Audio : MonoBehaviour
{
    public AudioClip pickupSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Play the pickup sound when the player enters the trigger zone
            PlayPickupSound();

            // You can add your custom logic for handling the pickup here

            // Destroy the object after pickup (you can replace this with your logic)
            Destroy(gameObject);
        }
    }

    private void PlayPickupSound()
    {
        if (pickupSound != null)
        {
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
        }
    }
}
