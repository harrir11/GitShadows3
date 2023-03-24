/*
    Name: Connie Huang
    Last modified: 2023-03-24
    Tutorial followed: https://youtu.be/DLAIYSMYy2g
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    // public GameObject effect;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // spawn the sun button at the first available inventory slot ! 
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {   // check whether the slot is EMPTY
                    inventory.isFull[i] = true;
                    // Instantiate(itemButton, inventory.slots[i].transform, false); // spawn the button so that the player can interact with it
                    Instantiate(itemButton, inventory.slots[i].transform.position, inventory.slots[i].transform.rotation, inventory.slots[i].transform);

                    // Instantiate(effect, transform.position, Quaternion.identity); 
                    // inventory.items[i] = 1; // makes sure that the slot is now considered FULL
                    
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
