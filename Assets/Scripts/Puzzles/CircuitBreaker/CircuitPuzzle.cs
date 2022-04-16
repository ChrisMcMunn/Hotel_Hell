using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CircuitPuzzle : MonoBehaviour
{
    private Image wire;

    public int numberConnected;
    public BeginCircuitPuzzle winCond;

    private void Awake()
    {
        wire = GetComponent<Image>();
    }

    private void Start()
    {
        winCond.WinGame = false;
    }

    void Update()
    {
        if (numberConnected == 3)
        {
            winCond.WinGame = true;
        }
    }
}
