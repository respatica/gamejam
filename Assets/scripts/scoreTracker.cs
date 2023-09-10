using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreTracker : MonoBehaviour
{
    // dont destroy on load? 

    private int score;
    [SerializeField] TextMeshProUGUI scoreText;

    public void AddPoint()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
