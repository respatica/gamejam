using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreTracker : MonoBehaviour
{
    public int score;
    public int levelScore;

    [SerializeField] TextMeshProUGUI scoreText;
    private playData data;

    private void Start()
    {
        data = GameObject.FindWithTag("data").GetComponent<playData>();
        score = data.score;
    }

    public void AddPoint()
    {
        score++;
        data.score = score;
        levelScore++; // this is reset to 0 every level from the objectCounter script

        scoreText.text = score.ToString();
    }
}
