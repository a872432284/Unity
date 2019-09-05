using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterFall : MonoBehaviour
{
    public GameObject water;
    public float TimeStart = 0;
    private float TimeInterval = 1.5f;
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
            if (water)
            {
                Vector2 newWater = new Vector2(transform.position.x - 0.08f, transform.position.y + 0.14f);
                Instantiate(water, newWater, Quaternion.identity);

            }
            TimeStart = 0;
        }
    }
}
