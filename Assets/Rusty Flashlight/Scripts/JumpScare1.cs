using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare1 : MonoBehaviour
{
    public GameObject JumpScare;
    public AudioSource JumpScare_Audio;
    void Start()
    {
        JumpScare.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag == "Player")
        {
            JumpScare.SetActive(true);
            JumpScare_Audio.Play();
            StartCoroutine(DisableImg());
        }
    }

    IEnumerator DisableImg()
    {
        yield return new WaitForSeconds(2);
        JumpScare.SetActive(false);
    }
}
