using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class camera : MonoBehaviour
{
    public Transform Mouse;
    private float distanceX;
    // Use this for initialization
    void Start()
    {
        distanceX = transform.position.x - Mouse.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mouse.position.x + distanceX,
            transform.position.y,
            transform.position.z);
    }
}
