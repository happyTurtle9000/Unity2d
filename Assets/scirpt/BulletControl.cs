using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public float bullet_speed;

    public GameObject bullet;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        bullet.transform.Translate(bullet_speed * Time.deltaTime,0,0);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
           Destroy(col.gameObject);
           Destroy(gameObject);
        }

     
    }

}
