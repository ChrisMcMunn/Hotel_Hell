using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginCircuitPuzzle : Interactable
{
    public GameUI pauseWorld;
    public GameObject PuzzleUI;

    private bool trigger;

    // Start is called before the first frame update
    void Start()
    {
        trigger = false;
    }

    private void BeginPuzzle()
    {
        if (!trigger)
        {
            pauseWorld.Pause();
            PuzzleUI.SetActive(true);
            Cursor.visible = true;
            Debug.Log("Play");
        }
        else
        {

        }
    }

    public override string GetDescription()
    {
        return null;

    }

    public override void Interact()
    {
        BeginPuzzle();
    }

}
