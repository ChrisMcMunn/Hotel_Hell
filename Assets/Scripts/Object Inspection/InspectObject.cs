using UnityEngine;

public class InspectObject : Interactable
{
	public Inspection Inspection;

	public GameObject InspectionObject;

	public bool inspecting;

	public GameObject Camera;

	public void Start()
	{
		inspecting = false;
	}

	public override string GetDescription()
	{
		if (!inspecting)
		{
			return "Press [E] to <color=yellow>inspect</color>.";
		}
		return "Press [E] to exit";
	}

	public override void Interact()
	{
		inspecting = !inspecting;
		Inspection.Update();
	}
}