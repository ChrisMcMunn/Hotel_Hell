using System;
using UnityEngine;

public class Inspection : MonoBehaviour
{
	public GameObject InspectionOBJ;

	public InspectObject InspectObject;

	public GameObject inspectionImage;

	//public bool hasPin;

	public float rotSpeed;

	private void Start()
	{
		InspectionOBJ.SetActive(value: false);
	}

	public void Update()
	{
		if (!InspectObject.inspecting)
		{
			InspectionOBJ.SetActive(value: false);
			inspectionImage.SetActive(value: false);
			Time.timeScale = 1f;
			Cursor.visible = false;
		}
		if (InspectObject.inspecting)
		{
			inspectionImage.SetActive(value: true);
			InspectionOBJ.SetActive(value: true);
			Time.timeScale = 0f;
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			//hasPin = true;
			float num = UnityEngine.Input.GetAxis("Mouse X") * rotSpeed * ((float)Math.PI / 180f);
			float num2 = UnityEngine.Input.GetAxis("Mouse Y") * rotSpeed * ((float)Math.PI / 180f);
			base.transform.RotateAround(Vector3.up, 0f - num);
			base.transform.RotateAround(Vector3.right, 0f - num2);
			base.transform.RotateAround(Vector3.down, num);
			base.transform.RotateAround(Vector3.left, num2);
		}
	}
}
