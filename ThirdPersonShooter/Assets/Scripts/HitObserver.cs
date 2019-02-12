using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObserver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //When the collision happens remove the object using Destroy
        //if(collision.gameObject.tag.Equals("enemy") == true)
        //{
        //    Destroy(collision.gameObject);
        //}

        if (collision.gameObject.name == "enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
