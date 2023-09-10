using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreGen : MonoBehaviour
{
    [SerializeField] private scoreTracker scorer;
    [SerializeField] private ballons boxs;


    private void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log(collider.gameObject.tag);
        if (collider.gameObject.tag=="box"){
             Debug.Log("HIToo!");
             scorer.AddPoint();
             boxs.AddPoint();
        }
        
    }
}
