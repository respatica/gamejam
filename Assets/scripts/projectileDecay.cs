using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileDecay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Decay());
    }

    IEnumerator Decay()
    {
        yield return new WaitForSeconds(8);
        Destroy(gameObject);
    }
}
