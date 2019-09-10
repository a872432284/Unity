using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanxiangqi : MonoBehaviour
{
    public SpriteRenderer car;
    public SpriteRenderer cat;
    public GameObject catgo;
    public GameObject cargo;
    public GameObject camera;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Car"))
        {

                car.flipX =!car.flipX;
                cat.flipX = !cat.flipX;
                car.GetComponent<carli>().Speed = -car.GetComponent<carli>().Speed;
                camera.GetComponent<camera>().distanceX = -camera.GetComponent<camera>().distanceX;
                Debug.Log("asd");

            Destroy(gameObject.GetComponent<fanxiangqi>());
            //catgo.GetComponent<cat>().addli = new Vector2(-catgo.GetComponent<cat>().addli.x, catgo.GetComponent<cat>().addli.y);
        }
    }
}
