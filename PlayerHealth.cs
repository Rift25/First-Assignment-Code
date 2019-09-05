using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int startingHealth = 100;
    public int currentHealth;


    CharacterMovement characterMovement;

    // Start is called before the first frame update
    void Start()
    {
        characterMovement = GetComponent<CharacterMovement>();
        currentHealth = startingHealth;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
