using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject losePanelUI;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == LayerMask.NameToLayer("PlayerFeet"))
        {
            Destroy(gameObject);
            ActivateLosePanel();
        }
    }

    public void ActivateLosePanel()
    {
        losePanelUI.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
}
