using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
 
    public void StartNewGame()
        {
            SceneManager.LoadScene("IntroCutscene", LoadSceneMode.Single);
        }
}
