using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GigaChadToplama : MonoBehaviour
{
    public AudioSource collectSound;
    public float donmehızı = 2f;
    void Update()
    {
        transform.Rotate(0,donmehızı ,0,Space.World);


        
    }
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        skorsistemi.theScore += 1;
        Destroy(gameObject);
    }
}
