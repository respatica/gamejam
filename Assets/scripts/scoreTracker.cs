using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreTracker : MonoBehaviour
{
    // dont destroy on load? 

    public int score;
    public int levelScore;

    [SerializeField] TextMeshProUGUI scoreText;

    public void AddPoint()
    {
        score++;
        levelScore++; // this is reset to 0 every level from the objectCounter script
        scoreText.text = score.ToString();
    }
}
