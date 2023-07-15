using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DONER : MonoBehaviour
{
    public float donmehızı = 2f;

    void OnTriggerEnter(Collider other)
   {
        Controller.moveSpeed += 10; 
        camerascript.moveSpeed += 10;

        Destroy(gameObject);

        
     
   }
    void Update()
    {
        transform.Rotate(0,donmehızı ,0,Space.World);
    }
}
