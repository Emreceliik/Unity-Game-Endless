using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karaktersecimi2 : MonoBehaviour
{
    void Start()
    {
        if(Karaktebuton.secilenkarakter == 1)
        {
            Destroy(gameObject);
        }
    }
}
