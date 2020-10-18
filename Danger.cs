using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Danger : MonoBehaviour
{

    public int secondsLeft = 60;
    public bool takingAway = false;
    public AudioSource dangerSound;
    public GameObject dangerImage;


    void Update()
    {

        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }

        if (secondsLeft == 30)
        {
            
            dangerImage.SetActive(true);
        }

        if (secondsLeft == 31)
        {
            dangerSound.Play();
        }

    }


    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        takingAway = false;
    }


}
