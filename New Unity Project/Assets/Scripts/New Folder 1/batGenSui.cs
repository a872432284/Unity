using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class batGenSui : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }
    private float juli(float ax,float ay,float bx,float by)
    {
        return (float)Math.Sqrt((bx - ax) * (bx - ax)+ (by - ay) * (by - ay));
    }
}
