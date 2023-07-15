using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -7f;
    public static float rightSide = 7f;
    public float InternalLeft;
    public float InternalRight;
   

    // Update is called once per frame
    void Update()
    {
        InternalLeft=leftSide;
        InternalRight=rightSide;
        
    }
}
