using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Wire : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Image wire;
    private LineRenderer WireLines;
    private Canvas canvas;
    private bool isDragStarted = false;

    private void Awake()
    {
        wire = GetComponent<Image>();
        WireLines = GetComponent<LineRenderer>();
        canvas = GetComponentInParent<Canvas>();
        WireLines.sortingOrder = 1;
    }

    private void Update()
    {
        if (isDragStarted)
        {
            Vector2 movePos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                canvas.transform as RectTransform,
                Input.mousePosition,
                canvas.worldCamera,
                out movePos);

            WireLines.SetPosition(0, transform.position);
            WireLines.SetPosition(1, canvas.transform.TransformPoint(movePos));
        }
    }

    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDragStarted = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDragStarted = false;
    }
}
