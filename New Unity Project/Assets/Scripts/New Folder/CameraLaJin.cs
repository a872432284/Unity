using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLaJin : MonoBehaviour
{

    public Camera cameras;

    public float endSize = 0;

    bool isCanLaJin = false;
    // Start is called before the first frame update
    void Start()
    {
        isCanLaJin = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCanLaJin)
        {
            cameras.orthographicSize -= Time.deltaTime;
            if (cameras.orthographicSize <= endSize)
            {
                isCanLaJin = false;
                cameras.orthographicSize = endSize;
            }
        }
       
        
    }
}
