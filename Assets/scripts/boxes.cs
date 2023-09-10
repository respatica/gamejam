using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxes : MonoBehaviour
{
    public AudioSource audioSource;
    int grav=0;
    public GameObject box;
    public bool counted;

    // Start is called before the first frame update
    void Start()
    {
          counted = false;
          audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
         box.GetComponent<Rigidbody2D>().gravityScale=grav;
    }
    
    void  OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("HIT!");
             grav=1;
        if (collision.transform.tag == "arrow")
        {
           audioSource.Play();
        }
    }
}
