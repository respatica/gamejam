using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public bool paused;
    private float previousTimeScale;
    [SerializeField] private GameObject pauseUIpanel;
    [SerializeField] private GameObject pauseButton;

    private void Start()
    {
        pauseUIpanel.SetActive(false);
        pauseButton.SetActive(true);
    }
    public void PauseGame()
    {
        paused = true;
        previousTimeScale = Time.timeScale;
        pauseUIpanel.SetActive(true);
        pauseButton.SetActive(false);
        // stop input in background

        // change timescale
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        paused = false;
        Time.timeScale = previousTimeScale;
        pauseUIpanel.SetActive(false);
        pauseButton.SetActive(true);

        //allow input again
    }
}
