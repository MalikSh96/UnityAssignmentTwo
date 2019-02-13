using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Movement : MonoBehaviour
{
    Timer t;
    float delayedTime = 2f; //2seconds
    [HideInInspector] public float speed = 300;

    float posX;
    float posY;
    float posZ;
    float targetX = 10;

    // Start is called before the first frame update
    void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
        //StartCoroutine("CoroutineDemo");
    }

    // Update is called once per frame
    void Update()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
        if(Timer())
        {
            MoveBasicTweening();
        }
    }

    bool Timer()
    {
        delayedTime -= Time.deltaTime; //delta means change from last time update was called, frame
        if(delayedTime <= 0)
        {
            return true;
        }
        return false;
    }

    void MoveBasicTweening()
    {
        //exponential movement
        posX += (targetX - posX) * 0.1f;
        transform.position = new Vector3(posX, posY, posZ);
    }

    void MoveBasic()
    {
        if (transform.position.x <= 10)
        {
            //Linear movement
            transform.position = new Vector3(transform.position.x + 0.01f * Time.deltaTime * speed, transform.position.y, transform.position.z); //vector3 has x,y,z, vector2 has x,y
        }
    }

    IEnumerator CouroutineDemo()
    {
        //Yield means that there is a scheduler that runs the work, like a thread
        while(true)
        {
            yield return new WaitForSeconds(1f);
            print("Hello World");
            yield return new WaitForSeconds(2f);
            print("Goodbye World");
        }
        yield return null;
    }
}
