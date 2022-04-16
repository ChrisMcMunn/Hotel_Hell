using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectCircuit : MonoBehaviour
{
    public GameObject correctWire;

    public Text Counter;

    public CircuitPuzzle Num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (correctWire.active)
        {
            Counter.color = Color.yellow;
            Num.numberConnected += 1;
        }
    }
}
