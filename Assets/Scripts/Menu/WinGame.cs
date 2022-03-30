using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : Interactable
{
    public BeginCircuitPuzzle checkWin;
    public GameUI pauseWorld;
    public GameObject WinUI;
    private bool trigger;

    // Start is called before the first frame update
    void Start()
    {
        trigger = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void EnterLobby()
    {
        if (checkWin.WinGame)
        {
            pauseWorld.Pause();
            WinUI.SetActive(true);
            Cursor.visible = true;
        }
    }

    public override string GetDescription()
    {
        return null;

    }

    public override void Interact()
    {
        EnterLobby();
    }
}