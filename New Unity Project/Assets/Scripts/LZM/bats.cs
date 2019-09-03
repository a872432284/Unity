using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bats : MonoBehaviour
{
    public float speed = 50.0f;
    float blastspeed;
    // Start is called before the first frame update
    void Start()
    {
        blastspeed = speed* 50.0f;
        Vector2 sudu = new Vector2(speed,0);
        GetComponent<Rigidbody2D>().velocity = sudu;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
