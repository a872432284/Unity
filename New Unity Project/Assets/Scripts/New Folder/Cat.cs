using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public Animator cat = null;
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
        if (Input.GetButton("Fire1"))
        {
            cat.SetBool("SlideIn", true);
            cat.SetBool("SlideIn", false);
        }
    }
}
