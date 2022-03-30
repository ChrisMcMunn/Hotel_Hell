using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginCircuitPuzzle : Interactable
{
    public GameUI pauseWorld;
    public GameObject PuzzleUI;
    public GameObject InteractionText;
    private bool trigger;

    public bool WinGame = true;
    public List<GameObject> Lights = new List<GameObject>(); 

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
            if (WinGame)
            {
                foreach (var GameObject in Lights)
                { 
                    GameObject.SetActive(false); 
                }
            }
        }
        else
        {
            InteractionText.SetActive(true);
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
