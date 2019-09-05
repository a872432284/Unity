using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dahuoqiu : MonoBehaviour
{
    public float speed;
    public float angleSpeed = 0.01f;
    public Transform target;
    public bool isRotate = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isRotate == true)
        {
            Move1();

        }
        else
        {
            Move2();
        }
    }
    void Move1()
    {
        float step = speed * Time.deltaTime;
        gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, new Vector2(6, 13), step);
        if (gameObject.transform.position == new Vector3(0, 3, 0))
        {
            isRotate = false;
        }
    }
    void Move2()
    {
        Vector2 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }
}