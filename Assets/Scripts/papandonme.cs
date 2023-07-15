using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class papandonme : MonoBehaviour
{
    public float donmehızı = 2f;

    void Update()
    {
        transform.Rotate(0,donmehızı ,0,Space.World);


        
    }
}
