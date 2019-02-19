using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

//https://cphbusiness.mrooms.net/pluginfile.php/200042/mod_resource/content/0/Assignment%203.pdf
public class PickUpsMovement : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        //Works
        StartCoroutine("CouroutineMovement");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CouroutineMovement()
    {
        //Yield means that there is a scheduler that runs the work, like a thread
        while(true)
        {
            yield return new WaitForSeconds(5f);
            MoveDoTweenPositive();
            yield return new WaitForSeconds(15f);
            MoveDoTweenNegative();
        }
        yield return null;
    }

    void MoveDoTweenPositive()
    {
        transform.DOMoveX(100, 10);
    }

    void MoveDoTweenNegative()
    {
        transform.DOMoveX(-100, 10);
    }
}

/*
 * Old version of code:
 * 
 * void Start()
    {
        //Spawning different locations
        for (int i = 0; i < 10; i++)
        {
            Vector3 newPos = new Vector3(Random.Range(-100, 100), Random.Range(0, 100), Random.Range(-100, 100));
            //PickUp is the spheres
            GameObject pickUp = Instantiate(prefab, newPos, Quaternion.identity) as GameObject;
        }

        //Works when printing to console
        StartCoroutine("CouroutineMovement");
    }
 * 
 * 
 */
