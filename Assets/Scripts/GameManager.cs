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
    //private void Awake()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (state)
            {
                case State.MENU:
                    SceneManager.LoadScene("GameScene");
                    Time.timeScale = 1f;
                    state = State.GAME;
                    break;

                case State.LOSE:
                    menuManager.QuitGame();
                    break;

                case State.WIN:
                    menuManager.QuitGame();
                    break;

                case State.GAME:
                    
                    break;
            }
        }
    }
}
