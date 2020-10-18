using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destruction : MonoBehaviour
{

    //public GameObject destroyedVersion;
    public GameObject door;
    public GameObject breakVersion;

    public AudioSource breakSound;


    public float bForce;
    protected Rigidbody rb;
    private int active = 0;

    //public GameObject brokenDoor;

    //private float endBit = 4f;

    //private Vector3 bvPos = new Vector3(-0.01f, 0.008f, -13.48f);
    private Quaternion bvRot = new Quaternion(0f, 0f, 0f, 0f);


    // Start is called before the first frame update
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    //Tested with mouse input
    //void OnMouseDown()
    //{
    //Instantiate(breakVersion, door.transform.position, bvRot);
    //Destroy(gameObject);
    //DestroyDoor();
    //}

    /*void Update()
    {

        if (brokenDoor.activeInHierarchy)
        {
            StartCoroutine(YouAreFree());
        }
        
    }*/


    void OnCollisionEnter(Collision collision)
    {   
        if (collision.collider.tag == "Object" && rb.velocity.magnitude > bForce && active == 0)
        {
            active++;
            Instantiate(breakVersion, door.transform.position, bvRot);          
            rb.AddExplosionForce(10f, Vector3.zero, 0f);
            breakSound.Play();
            Destroy(gameObject);
            Destroy(door);
            //brokenDoor.SetActive(true);
            SceneManager.LoadScene(3);
        }
     }



    /*IEnumerator YouAreFree()
    {
            {
                yield return new WaitForSeconds(4);
                SceneManager.LoadScene(3);
            }
    }*/


}
