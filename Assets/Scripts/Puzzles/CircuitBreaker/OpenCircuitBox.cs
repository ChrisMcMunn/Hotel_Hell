using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCircuitBox : Interactable
{

    public Animator CircuitBoxAnim;
    private bool trigger;

    // Start is called before the first frame update
    void Start()
    {
        CircuitBoxAnim.SetBool("Open", false);
        trigger = false;
    }

    private void OpenBox()
    {
        if (!trigger)
        {
            CircuitBoxAnim.SetBool("Open", true);
        }
        else
        {

            CircuitBoxAnim.SetBool("Open", false);
        }
    }

    public override string GetDescription()
    {
        return "Interact";
    }

    public override void Interact()
    {
        OpenBox();
    }
}
