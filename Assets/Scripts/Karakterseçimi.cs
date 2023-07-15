using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakterseçimi : MonoBehaviour
{
    
    void Start()
    {
        if(Karaktebuton.secilenkarakter == 2)
        {
            Destroy(gameObject);
        }
    }

    

}
