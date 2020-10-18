using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    public float waitTime;


    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(IntroWait());

    }

    IEnumerator IntroWait()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(1);

    }
    
}
