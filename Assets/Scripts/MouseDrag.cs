using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{

    bool grabbed = false;
    float distanceFromScreen = 6f;

    public float distMax = 15f;
    public float distMin = 5f;

    private void Update()
    {
        if (grabbed)
        {
            //finding cursor position and then snapping the player to it
            Ray mousePos = Camera.main.ScreenPointToRay(Input.mousePosition);
            this.transform.position = mousePos.origin + (mousePos.direction * distanceFromScreen);
            distanceFromScreen += Input.mouseScrollDelta.y;
            if (distanceFromScreen < distMin)
            {
                distanceFromScreen = distMin;
            }
            else if (distanceFromScreen > distMax)
            {
                distanceFromScreen = distMax;
            }
        }
    }
    private void OnMouseDown()
    {
        grabbed = true;
    }
    private void OnMouseUp()
    {
        grabbed = false;
    }

}
