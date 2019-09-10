using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    /// <summary>
    /// 闸门
    /// </summary>
    public GameObject door;

    /// <summary>
    /// 开关关闭
    /// </summary>
    public GameObject KaiGuanOpen;

    /// <summary>
    /// 开关打开
    /// </summary>
    public GameObject KaiGuanClose;

    bool isCanMoveDoor = false;
    // Start is called before the first frame update
    void Start()
    {
        KaiGuanClose.SetActive(true);
        KaiGuanOpen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * 10);
        }
        if (isCanMoveDoor)
        {
            door.transform.position = Vector3.Lerp(door.transform.position, new Vector3(0, 3, 0), Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "kaiguan")
        {
            KaiGuanClose.SetActive(false);
            KaiGuanOpen.SetActive(true);
            isCanMoveDoor = true;
        }
    }
}
