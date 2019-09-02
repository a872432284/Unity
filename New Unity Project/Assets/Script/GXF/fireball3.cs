using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball3 : MonoBehaviour
{
    public float movespeed = 5.0f;
    float fireball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireball = movespeed * 2.0f;
        vector3 sudu = new vector3(0, fireball,0);
        rigdbody.velocity = sudu;

    }
}
