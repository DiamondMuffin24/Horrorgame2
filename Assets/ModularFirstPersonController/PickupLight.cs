using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupLight : MonoBehaviour
{


    public GameObject FlashLightOnPlayer;


    // Start is called before the first frame update
    void Start()
    {
        FlashLightOnPlayer.SetActive(false);
    }


    private void OnTriggerStay(Collider other)
    {

        Debug.Log("Trigger");


        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                Debug.Log("Light deactivated");
                FlashLightOnPlayer.SetActive(true);
                Debug.Log("FlashLight has been picked up");
            }
       
        }
    }

}
