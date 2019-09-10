using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterFall : MonoBehaviour
{
    public float TimeStart=0;
    private float TimeInterval = 1.5f;
    public GameObject water;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeStart += Time.deltaTime;
        
        if(TimeStart>=TimeInterval)
        {
            if(water)
            {
                Vector3 newWater = new Vector3(transform.position.x-0.03f,transform.position.y+0.05f,0);
              Instantiate(water, newWater, Quaternion.identity);
            } TimeStart = 0;
        }
        
       
    }
   
}
