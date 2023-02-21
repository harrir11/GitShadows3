/*
    Name: Connie Huang
    Last modified: 2023-02-21
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // public float speed = 5f;
    // public float playAreaWidth = 9f;
    // public float playAreaHeight = 9f;
    // public Color playAreaColor = Color.green;

    // private Vector3 targetPosition;

    // private void OnDrawGizmos()
    // {
    //     Gizmos.color = playAreaColor;
    //     Gizmos.DrawWireCube(Vector3.zero, new Vector3(playAreaWidth, playAreaHeight, 0f));
    // }

    // private void Update()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //         Plane groundPlane = new Plane(Vector3.forward, Vector3.zero);
    //         float distance;
    //         if (groundPlane.Raycast(ray, out distance))
    //         {
    //             Vector3 hitPoint = ray.GetPoint(distance);
    //             targetPosition = new Vector3(hitPoint.x, hitPoint.y, transform.position.z);
    //             targetPosition = new Vector3(
    //                 Mathf.Clamp(targetPosition.x, -playAreaWidth / 2, playAreaWidth / 2),
    //                 Mathf.Clamp(targetPosition.y, -playAreaHeight / 2, playAreaHeight / 2),
    //                 targetPosition.z
    //             );
    //         }
    //     }

    //     transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    // }
    
    public float speed = 5f;
    public Color playAreaColor = Color.green;

    public Vector2[] playAreaPoints;

    private Vector3 targetPosition;

    private void OnDrawGizmos()
    {
        Gizmos.color = playAreaColor;

        if (playAreaPoints != null && playAreaPoints.Length >= 2)
        {
            for (int i = 0; i < playAreaPoints.Length; i++)
            {
                int j = (i + 1) % playAreaPoints.Length;
                Gizmos.DrawLine(playAreaPoints[i], playAreaPoints[j]);
            }
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Plane groundPlane = new Plane(Vector3.forward, Vector3.zero);
            float distance;
            if (groundPlane.Raycast(ray, out distance))
            {
                Vector3 hitPoint = ray.GetPoint(distance);
                targetPosition = new Vector3(hitPoint.x, hitPoint.y, transform.position.z);

                // Check if the target position is inside the play area
                if (IsPointInsidePlayArea(targetPosition))
                {
                    transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
                }
            }
        }
    }

    private bool IsPointInsidePlayArea(Vector3 point)
    {
        int intersectCount = 0;

        // Check how many times a line from the point intersects with the play area edges
        for (int i = 0; i < playAreaPoints.Length; i++)
        {
            int j = (i + 1) % playAreaPoints.Length;

            if (((playAreaPoints[i].y <= point.y) && (point.y < playAreaPoints[j].y))
                || ((playAreaPoints[j].y <= point.y) && (point.y < playAreaPoints[i].y)))
            {
                float xIntersection = (point.y - playAreaPoints[i].y) / (playAreaPoints[j].y - playAreaPoints[i].y) * (playAreaPoints[j].x - playAreaPoints[i].x) + playAreaPoints[i].x;
                if (point.x < xIntersection)
                {
                    intersectCount++;
                }
            }
        }

        return (intersectCount % 2 == 1);
    }
}