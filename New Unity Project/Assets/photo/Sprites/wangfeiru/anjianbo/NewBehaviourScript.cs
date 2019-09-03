using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    //private bool circle1 = false;
    Vector3 mousePositionOnScreen;

    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        /*circle1 = */
        GameObject.FindGameObjectWithTag("circle");
        Transform trans = GetComponent<Transform>();
        Animation ani = GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var mousePosition = Input.mousePosition;
            mousePosition.z = 10;
            var world = Camera.main.ScreenToWorldPoint(mousePosition);
            gameObject.transform.position = world;
            gameObject.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }


    }

}