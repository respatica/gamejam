using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class transitionCue : MonoBehaviour
{
    private int currentScene;
    [SerializeField] private GameObject lvlOverCanvas;
    private scoreTracker scorer;

    [SerializeField] private TextMeshProUGUI totalpoints;
    [SerializeField] private TextMeshProUGUI levelpoints;


    public void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        lvlOverCanvas.SetActive(false);
        scorer = GameObject.FindWithTag("score").GetComponent<scoreTracker>();
    }

    public void LoadNextScene()
    {
        int nextScene = currentScene + 1;
        SceneManager.LoadSceneAsync(nextScene);
    }

    public void OpenEndLevelUI()
    {
        lvlOverCanvas.SetActive(true);
        updatePoints();
    }

    public void updatePoints()
    {
        totalpoints.text = scorer.score.ToString();
        levelpoints.text = scorer.levelScore.ToString();
    }
}
