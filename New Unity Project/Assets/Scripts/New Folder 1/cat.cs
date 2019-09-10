//猫身上的代码
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    private Animator Cat = null;
    private Vector2 dead_get_li = new Vector2(-30f, 80f);//死亡加力
    private float y;//猫每次接触板子会记录一次当前y坐标
    private float ymax = 0.8f;//猫能跳跃的最大高度
    public static bool jump;//是否在地面上；
    public  static bool Catisdead = false;
    public Vector2 addli = new Vector2(0, 10);
    // Start is called before the first frame update
    void Start()
    {
        Cat = GetComponent<Animator >();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //猫移动的方法
    private void run()
    {
       
    }
    private void FixedUpdate()
    {
        if(GetComponent<Transform>().position.y<=-10)
        {
            CatDead();
        }
        if(Input.GetButton("Fire1"))
        {
            Cat.SetBool("anjian",true);
            Cat.SetBool("chudi", false);
            if (transform.position.y >= y + ymax)
            {
                jump = false;
            }
            else if(jump)
            {
                    GetComponent<Rigidbody2D>().AddForce(addli);      
            }
        }


    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("huoqiu"))
        {
            CatDead();
        }
        else if(collision.gameObject.CompareTag("bianfujump"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(50, 100));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        jump = false;
        if(collision.gameObject.CompareTag("huoqiu"))
        {
            CatDead();
        }
        if(collision.gameObject.CompareTag("Car"))
       {
            y = transform.position.y;
            jump = true;
        Cat.SetBool("chudi", true);
         }
        Cat.SetBool("anjian", false);
    }
        
    private void CatDead()
    {

            if (!Catisdead)
        {

            Cat.SetTrigger("isdead");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().AddForce(dead_get_li);
            Cat.GetComponent<Collider2D>().enabled = false;
            Debug.Log("Cat is dead");
            Catisdead = true;
        }
    }
}
