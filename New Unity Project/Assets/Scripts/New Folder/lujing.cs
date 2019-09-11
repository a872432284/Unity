using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lujing : MonoBehaviour
{
    public iTween.EaseType type;
    public float Speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Hashtable args = new Hashtable();
        Destroy(gameObject.GetComponent<Collider2D>());
        args.Add("speed", Speed);
        args.Add("path", iTweenPath.GetPath("Mypath"));
        iTween.MoveTo(collision.gameObject, args);
    }
}
