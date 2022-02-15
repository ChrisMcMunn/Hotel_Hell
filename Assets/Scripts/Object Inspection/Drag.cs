using System;
using UnityEngine;

public class Drag : MonoBehaviour
{
	private float rotSpeed = 20f;

	private void OnMouseDrag()
	{
		float num = UnityEngine.Input.GetAxis("Mouse X") * rotSpeed * ((float)Math.PI / 180f);
		float angle = UnityEngine.Input.GetAxis("Mouse Y") * rotSpeed * ((float)Math.PI / 180f);
		base.transform.RotateAround(Vector3.up, 0f - num);
		base.transform.RotateAround(Vector3.right, angle);
	}
}