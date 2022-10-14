using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    private void Update()
    {
        //spawn item




    }

    //pickup item and despawn it 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().Play("Item Pickup");

            this.gameObject.SetActive(false);
        }
    }
}
