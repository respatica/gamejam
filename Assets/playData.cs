using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playData : MonoBehaviour
{
    public int score;
    public List<GameObject> furniture;

    public static playData instance;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = this;
        }
    }
}
