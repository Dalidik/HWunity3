using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
   
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch screenTouch = Input.GetTouch(0);
            if (screenTouch.phase == TouchPhase.Moved)
            {
                transform.Rotate(0f, screenTouch.deltaPosition.x, 0f);
            }
        }
    }
}
