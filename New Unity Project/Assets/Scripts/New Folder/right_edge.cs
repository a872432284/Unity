using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right_edge : MonoBehaviour
{
    private bool edge = false;
    // Start is called before the first frame update
    void Start()
    {
        if (edge == true)
        {
            GameObject.FindGameObjectWithTag("Player").transform.Translate(new Vector3(-0.5f, 0));
        }
        edge = !edge;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            edge = true;
        }
    }
}
