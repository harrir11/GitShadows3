using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanityDamage : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;

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
        TakeDamage(0.002f); 
    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        sanityBar.SetHealth(currentHealth);
    }
}
