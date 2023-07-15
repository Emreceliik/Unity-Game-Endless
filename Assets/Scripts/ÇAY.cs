using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ÇAY : MonoBehaviour
{
     public float donmehızı = 2f;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Karaktercan.health += 1;
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,donmehızı ,0,Space.World);
    }
}
