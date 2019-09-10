using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_Particle : MonoBehaviour
{
    public GameObject fire;
    public GameObject fire_Par;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            fire.SetActive(false);
            Vector2 fire_Particle = new Vector2(transform.position.x, transform.position.y);
            Instantiate(fire_Par, fire_Particle, Quaternion.identity);
            fire_Par.SetActive(true);
        }
       
    }
}
