using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public  bool isCanMove = false;
    public float MoveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCanMove)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(MoveSpeed, 0));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isCanMove = true;
        }
    }
}
