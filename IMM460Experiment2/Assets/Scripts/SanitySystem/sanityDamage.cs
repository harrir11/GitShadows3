using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanityDamage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public sanityBar sanityBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        sanityBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        sanityBar.SetHealth(currentHealth);
    }
}
