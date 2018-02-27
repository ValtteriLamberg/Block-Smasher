using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float minPos, maxPos;
    
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
		/*
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);

        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

        paddlePos.x = Mathf.Clamp(mousePosInBlocks, -7.5f, 7.5f);

        this.transform.position = paddlePos;
		*/


		Vector3 mousepos = Camera.main.ScreenToWorldPoint (Input.mousePosition);


		transform.position = new Vector2 (Mathf.Clamp(mousepos.x,minPos, maxPos), transform.position.y);


    }
}
