using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Move : MonoBehaviour
{
    float distance = 19.0f;
    void OnMouseDrag()
    {
        //Debug.Log("Drag!");
        Vector3 mouse_position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mouse_position);

        transform.position = objPosition;
    }
}
