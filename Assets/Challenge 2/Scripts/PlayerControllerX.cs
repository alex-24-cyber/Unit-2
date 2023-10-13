using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 1; // initialize to a positive value
    
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = 1; // reset the cooldown
        }
        
        // update the cooldown every frame
        if (cooldown >= 0) {
            cooldown -= Time.deltaTime; 
        }

    }
}

