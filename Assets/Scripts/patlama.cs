using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patlama : MonoBehaviour
{
    public AudioSource deathSound;
    
    void OnTriggerEnter(Collider other)
   {
        Karaktercan.health -= 1; 
        deathSound.Play();
        Destroy(gameObject);

        
     
   }
}
