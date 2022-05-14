using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject HealTH_ThiNG;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnHealth", 0, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnHealth()
    {
        float y = Random.Range(6.5f,-6.5f);

        Instantiate(HealTH_ThiNG, new Vector2(12.3f,y), Quaternion.identity);
    }
}
