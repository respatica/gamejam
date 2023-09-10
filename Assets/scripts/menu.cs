using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject menuPanel;
    public bool f=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape")){
           menuPanel.SetActive(f);
           f=!f;
        }
    }
    public void Mainmenu()
        {
            GameObject data = GameObject.FindWithTag("data");
            Destroy(data);
            
            SceneManager.LoadScene("start menu", LoadSceneMode.Single);
        }
    public void exitGame()
        {
            Application.Quit();
        }
}
