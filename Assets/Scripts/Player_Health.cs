using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(6);
        }
        
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

}
