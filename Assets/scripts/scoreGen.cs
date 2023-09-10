using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreGen : MonoBehaviour
{
    [SerializeField] private scoreTracker scorer;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.tag == "box" && !collider.gameObject.GetComponent<boxData>().counted)
        {
            collider.gameObject.GetComponent<boxData>().counted = true;
            scorer.AddPoint();
        }
    }
}
