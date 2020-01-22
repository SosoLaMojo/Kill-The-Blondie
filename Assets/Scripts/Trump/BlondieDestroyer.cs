using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlondieDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject winPanelUI;
    [SerializeField] private Button quitButton;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            ActivateWinPanel();
        }
    }

    public void ActivateWinPanel()
    {
        winPanelUI.gameObject.SetActive(true);
        Time.timeScale = 0f;
        quitButton.Select();
    }
}
