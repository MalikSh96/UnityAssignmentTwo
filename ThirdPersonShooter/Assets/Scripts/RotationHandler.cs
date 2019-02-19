using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationHandler : MonoBehaviour
{
    int rotateX = 5;
    int rotateZ = 0;
    int rotateY = 5;

    //Gonna be used for optimization
    //public GameObject toBeFound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateX, rotateY, rotateZ); 
        //ObjectLocator();
    }

    //Code below is aimed to be part of optimization
    void ObjectLocator()
    {
        GameObject.FindWithTag("enemy");
        print("found");
        transform.Rotate(rotateX, rotateY, rotateZ);
    }
}
