using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CameraRotate : MonoBehaviour
{
    public Slider rotateSensController;

    private float rotateSens = 2f;

    private float translateSens = 0.5f;

    public float yLimitUpper = 9f;

    public float yLimitLower = 0f;

    private float rotateLastX = 0f;

    private float spinSens = 1f;

    // Update is called once per frame
    void Update()
    {
        rotateSens = rotateSensController.value * 4;

        if (Input.GetMouseButton(0))
        {
            //Make the object rotate a bit after moving it
            if(Input.GetTouch(0).deltaPosition.x != 0)
            {
                rotateLastX = Mathf.Round(Input.GetTouch(0).deltaPosition.x);
            }
            // translate camera Up & Down

            transform.Translate(0, Input.GetTouch(0).deltaPosition.y * Time.deltaTime * -1  * translateSens, 0);
            if(transform.position.y > yLimitUpper)
            {
                transform.position = new Vector3(0, yLimitUpper, 0);
            }
            if(transform.position.y < yLimitLower)
            {
                transform.position = new Vector3(0, yLimitLower, 0);
            }
        }

        transform.Rotate(0, rotateLastX * rotateSens * Time.deltaTime, 0);

        if (rotateLastX > 0 + spinSens)
        {
            rotateLastX = rotateLastX - spinSens;
        }
        else if(rotateLastX < 0 - spinSens)
        {
            rotateLastX = rotateLastX + spinSens;
        }
        else
        {
            rotateLastX = 0;
        }
    }
}
