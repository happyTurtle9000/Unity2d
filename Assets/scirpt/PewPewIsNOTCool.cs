using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewPewIsNOTCool: MonoBehaviour
{
    // Start is called before the first frame update
    public float X;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate( X * Time.deltaTime,0,0);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
           Destroy(col.gameObject);
        }
    }
}
