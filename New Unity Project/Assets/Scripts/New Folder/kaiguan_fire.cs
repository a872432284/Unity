using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaiguan_fire : MonoBehaviour
{
    public GameObject fire;
    public GameObject fire_Par;
    public GameObject red;
    public GameObject green;
    // Start is called before the first frame update
    void Start()
    {
        red.SetActive(true);
        green.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        red.SetActive(false);
        green.SetActive(true);
        fire.SetActive(false);
        Vector2 fire_Particle = new Vector2(fire.transform.position.x, fire.transform.position.y);
        Instantiate(fire_Par, fire_Particle, Quaternion.identity);
        fire_Par.SetActive(true);
    }
}
