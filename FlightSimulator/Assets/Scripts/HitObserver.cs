using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitObserver : MonoBehaviour
{
    private int counter;
    public AudioSource pickUpSound;

    // Start is called before the first frame update
    void Start()
    {
        pickUpSound = GetComponent<AudioSource>();
        
        counter = 0;

        //UpdateScore();
        //GetComponent<AudioSource>().playOnAwake = false;
        //GetComponent<AudioSource>().clip = pickUpSound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //When the collision happens remove the object using Destroy
        pickUpSound.Play();
        Destroy(collision.gameObject);
        //Destroy(gameObject);
        
        counter++;
        print(counter);
    }
}

