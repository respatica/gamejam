using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreTracker : MonoBehaviour
{
    // dont destroy on load? 

    public int score;
    [SerializeField] TextMeshProUGUI scoreText;

    public void AddPoint()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
