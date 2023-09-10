using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreGen : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.tag == "box" && !collider.gameObject.GetComponent<boxes>().counted)
        {
            collider.gameObject.GetComponent<boxes>().counted = true;
            GameObject.FindWithTag("score").GetComponent<scoreTracker>().AddPoint();
        }
    }
}
