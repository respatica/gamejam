using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    private scoreTracker scoreUI;
    [SerializeField] private GameObject win40;
    [SerializeField] private GameObject win30;
    [SerializeField] private GameObject lose20;
    [SerializeField] private GameObject lose10;

    private void Start()
    {
        win40.SetActive(false);
        win30.SetActive(false);
        lose20.SetActive(false);
        lose10.SetActive(false);
    }

    public void determineGame()
    {
        if (scoreUI.score == 40)
        {
            win40.SetActive(true);
        }
        else if (scoreUI.score > 30)
        {
            win30.SetActive(true);
        }
        else if (scoreUI.score > 20)
        {
            lose20.SetActive(true);          
        }
        else
        {
            lose10.SetActive(true);     
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("start menu", LoadSceneMode.Single);
    }
}
