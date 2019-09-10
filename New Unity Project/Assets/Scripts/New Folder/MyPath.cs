using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPath : MonoBehaviour
{
    public iTween.EaseType type;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("tuijin"))
        {   Debug.Log("ok");
            Hashtable args = new Hashtable();
            args.Add("speed", 3.0f);
            args.Add("path", iTweenPath.GetPath("MyPath"));
            args.Add("easeType", type);
            iTween.MoveTo(gameObject, args);
        }
    }
}
