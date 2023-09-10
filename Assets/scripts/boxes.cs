using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxes : MonoBehaviour
{
    AudioSource audioSource;
    int grav=0;
    public GameObject box;

    // Start is called before the first frame update
    void Start()
    {
         audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
         box.gravityScale=grav;
    }
    void OnCollisionEnter(Collision collision)
    {
        grav=1;
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        if (collision.relativeVelocity.magnitude > 2)
            audioSource.Play();
    }
}
