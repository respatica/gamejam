using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectCounter : MonoBehaviour
{
    [SerializeField] private scoreTracker scorer;
    [SerializeField] private GameObject[] levelFurniture;
    public List<GameObject> savedActiveFurniture; // add to dont destroy on load object

    public void Start()
    {
        scorer.levelScore = 0;
    }

    public void EnableAtEnd() // call from level manager 
    {
        for (int i = 0; i > scorer.levelScore; i++) // for as many points as were made this level
        {
            levelFurniture[i].SetActive(true);
            savedActiveFurniture.Add(levelFurniture[i]);
        }
    }
}
