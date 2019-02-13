using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //To shoot we will make a new gameobject, a new variable, to hold the new projectile
            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.gameObject.SetActive(true);
            //Putting it at the right place and making it move in the right direction
            projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
            //^ setting projectile to position of the player, but by timing it with 2, the projectile doesn't spawn in the player

            //To make the projectile move in the right speed
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 20; //40 is the speed of the projectile

            Destroy(projectile.gameObject, 3);
        }  
    }
}
