using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guidaoTrigger : MonoBehaviour
{
  
   
    public Collider2D Car_edge;
    public Collider2D Wheel_left;
    public Collider2D Wheel_right;
    
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

        Car_edge.enabled = false;
        Wheel_left.enabled = false;
        Wheel_right.enabled = false;

    }
}
    

