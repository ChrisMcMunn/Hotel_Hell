using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    int nextScene;

    void Update()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextScene == 2)
        {
            nextScene = 0;
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(nextScene);
        Debug.Log(nextScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
