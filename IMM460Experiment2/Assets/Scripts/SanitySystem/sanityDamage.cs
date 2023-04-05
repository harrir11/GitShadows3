using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sanityDamage : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public GameObject GameController;

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
        if(currentHealth <= 0) {
            Destroy(GameController);

            SceneManager.LoadScene("Bedroom_Origin_RH");
        }
    }
}
