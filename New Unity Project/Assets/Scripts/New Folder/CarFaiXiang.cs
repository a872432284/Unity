using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFaiXiang : MonoBehaviour
{
    public float MoveSpeed = 10;
    bool isCanMoveRight = false;
    // Start is called before the first frame update
    void Start()
    {
        isCanMoveRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCanMoveRight)
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);
        }
        else 
        {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "fanxiangqi")
        {
            isCanMoveRight = !isCanMoveRight;
        }
    }
}
