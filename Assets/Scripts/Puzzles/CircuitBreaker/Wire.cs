using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Wire : MonoBehaviour
{
    public List<GameObject> Wires = new List<GameObject>();

    public int listPlacement = 0;

    void Update()
    {
        
    }

    public void ConnectWire()
    {
        if (listPlacement == Wires.Count)
        {
            listPlacement = 0;
        }

        Wires[listPlacement].SetActive(true);
        
        if (listPlacement == 0)
        {
            Wires[Wires.Count -1].SetActive(false);
        }
        
        if((listPlacement < Wires.Count) && (listPlacement != 0))
        {
            Wires[listPlacement - 1].SetActive(false);          
        }

        listPlacement += 1;
        
    }
}
