using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingWater : MonoBehaviour
{
    public GameObject waterPlane;
    public GameObject GameOverUI;
    public GameUI pauseWorld;

    public float speed;
    Vector3 direction;
    public float maxHeight;
    public float holdSpeed;


    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.up;
        holdSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        waterPlane.transform.Translate(direction * speed * Time.unscaledDeltaTime);

        if (waterPlane.transform.position.y >= maxHeight)
        {
            speed = 0;
            GameOverUI.SetActive(true);
            pauseWorld.Pause();
            Cursor.visible = true;
        }
    }

}
