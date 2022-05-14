using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoeMama : MonoBehaviour
{

    public GameObject Shuvro_Sarker;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float y = Random.Range(6.5f,-6.5f);

        Instantiate(Shuvro_Sarker, new Vector2(12.3f,y), Quaternion.identity);
    }
}
