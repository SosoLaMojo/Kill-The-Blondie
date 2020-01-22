using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] MenuManager menuManager;

    enum State
    {
        MENU,
        LOSE,
        WIN,
        GAME
    }

    [SerializeField] State state = State.MENU;



    private void Update()
    {
        switch (state)
        {
            case State.MENU:
                Debug.Log("menu");
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Debug.Log("load bordel");
                    SceneManager.LoadScene("GameScene");
                    Time.timeScale = 1f;
                    state = State.GAME;
                }
                break;

            case State.LOSE:
                menuManager.ReturnToMenu();
                break;

            case State.WIN:
                menuManager.ReturnToMenu();
                break;

            case State.GAME:
                Debug.Log("game");
                break;
        }
    }
}
