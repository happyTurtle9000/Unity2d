  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class GunControl : MonoBehaviour
{
    // Start is called before the first frame update

    public float gun_speed;

    public GameObject gun;

    public GameObject gun_pointer;

    public GameObject bullet_object;

    public int BulletCounter;
 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gun == null)
        {
            return;
        }
        //float X = Input.GetAxis("Horizontal") * Time.deltaTime * gun_speed;
        float Y = Input.GetAxis("Vertical") * Time.deltaTime * gun_speed;
        gun.transform.Translate(0,Y,0);



        if (Input.GetKeyDown(KeyCode.Space))

        {
            Instantiate(bullet_object,gun_pointer.transform.position,Quaternion.identity);
        }
    }

    void ReloadBullet(int numOfGuns)
    {
        BulletCounter = numOfGuns;
    }


}