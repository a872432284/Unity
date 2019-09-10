using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJiaolianBan : MonoBehaviour
{
  
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.eulerAngles.z < 50)
        {
            gameObject.transform.Rotate(new Vector3(0, 0, 50), Time.deltaTime * 50);
        }
       
    }
}
