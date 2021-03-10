using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathGenerator : MonoBehaviour
{
    float x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other)
    {

            x = Random.Range(-1.0f, 1.0f);
            if (x > 0)
            {
                transform.position = new Vector3(Random.Range(-10.0f, -1.0f), transform.position.y, 0);
            }
            else
            {
                transform.position = new Vector3(transform.position.x, Random.Range(-4.5f, -0.5f), 0);
            }
        }
        //Debug.Log("asd");          
    
}
