using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    private Rigidbody2D rig;   //刚体

    private float jumpForce;  //跳跃的力

    private float horizontal;  //水平偏移量

    private float moveSpeed; //水平移动速度绝对值



    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();   //获取主角刚体组件
        jumpForce = 200f;   //跳跃力的大小

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {     

            rig.AddForce(new Vector2(0, jumpForce));   //给刚体一个向上的力

            horizontal = Input.GetAxis("Horizontal");   //水平方向按键偏移量

;

        }
    }
}
