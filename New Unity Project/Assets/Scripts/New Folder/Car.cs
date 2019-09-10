﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private Rigidbody2D rig = null;
    public float Speed = 10.0f;
    public bool isCanMove = false;
    public Animator wheel_1;
    public Animator wheel_2;
    // Start is called before the first frame update
    void Start()
    {
        rig=gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if (isCanMove == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Speed, 0));
        }
    }
    private void FixedUpdate()
    {
        
       
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
          
            isCanMove = true;
            wheel_1.enabled = true;
            wheel_2.enabled = true;
        }
    }
}
