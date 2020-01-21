using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private Scene scene;
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("load bordel");
            SceneManager.LoadScene("GameScene");
            Time.timeScale = 1f;
        }
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
