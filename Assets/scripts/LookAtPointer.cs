using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPointer : MonoBehaviour
{
    [SerializeField] private Transform Bone1;
    public float xFlipCoordinate;
    public bool RightFacing;

    private void Update()
    {
        LAMouse();
        FlipX();
    }
    
    private void LAMouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - Bone1.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
        Bone1.rotation = rotation;
    }

    private void FlipX()
    {
        if (Input.mousePosition.x < xFlipCoordinate)
        {
            // face right
            if (!RightFacing)
            {
                Vector3 newScale = Bone1.transform.localScale;
                newScale.x *= -1;
                Bone1.transform.localScale = newScale;
            }
            RightFacing = true;
        }
        else
        {
            //face left
            if (RightFacing)
            {
                Vector3 newScale = Bone1.transform.localScale;
                newScale.x *= -1;
                Bone1.transform.localScale = newScale;
            }
            RightFacing = false;
        }
    }
}
