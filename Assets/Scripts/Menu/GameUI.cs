using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool InventoryOpen = false;

    public GameObject pauseMenuUI;
    public GameObject inventoryUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (GameIsPaused)
            {
                Resume();
                pauseMenuUI.SetActive(false);
                GameIsPaused = false;
                Cursor.visible = false;
            }
            else
            {
                Pause();
                GameIsPaused = true;
                pauseMenuUI.SetActive(true);
                Cursor.visible = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (InventoryOpen)
            {
                Resume();
                InventoryOpen = false;
                inventoryUI.SetActive(false);
                Cursor.visible = false;
            }
            else
            {
                Pause();
                InventoryOpen = true;
                inventoryUI.SetActive(true);
                Cursor.visible = true;
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        Cursor.visible = false;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        Cursor.visible = true;
    }
}
