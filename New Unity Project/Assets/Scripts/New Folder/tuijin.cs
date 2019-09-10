using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuijin : MonoBehaviour
{
   
    public Animator tui;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
       
         tui.enabled = true;
        
    
        
    }
}
