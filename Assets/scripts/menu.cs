using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Mainmenu()
        {
            SceneManager.LoadScene("startmenu", LoadSceneMode.Single);
        }
    public void exitGame()
        {
            Application.Quit();
        }
}
