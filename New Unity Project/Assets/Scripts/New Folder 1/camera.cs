using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform Cat;
    public float distanceX = 5f;
    private float came_y;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        if (!cat.Catisdead)
        {
            if (Cat.transform.position.y >= 0)
            {
                came_y = Cat.transform.position.y + 1;
            }
            else
            {
                came_y = 2.0f;
            }
            transform.position = new Vector3(Cat.position.x + distanceX, Cat.position.y, -10);
        }

    }
}
