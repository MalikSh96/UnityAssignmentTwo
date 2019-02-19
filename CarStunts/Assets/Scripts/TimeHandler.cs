using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeHandler : MonoBehaviour
{
    float currentCountDownValue;
    GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        if (currentCountDownValue <= 0)
        {

        }
    }

    //Works, needs to be displayed on UI
    public IEnumerator StartCountdown()
    {
        float countdownValue = 10;
        currentCountDownValue = countdownValue;
        while (currentCountDownValue > 0)
        {
            print("Countdown: " + currentCountDownValue);
            //Debug.Log("Countdown: " + currentCountDownValue);
            yield return new WaitForSeconds(1.0f);
            currentCountDownValue--;
        }
    }

    //Does not work
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "ramp")
        {
            currentCountDownValue += 10;
        }
    }
}
