using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    
    public int secondsLeft = 60;
    public bool takingAway = false;

    void Update()
    {

        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }

        if (secondsLeft == 0)
        {
            SceneManager.LoadScene(2);
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