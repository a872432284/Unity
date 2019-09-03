using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float Force = 50.0f;
  
    public Rigidbody2D car;
    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        car.AddForce(new Vector2(Force, 0));
      
    }
}
