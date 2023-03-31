/*
    Name: Connie Huang
    Last modified: 2023-03-24
    Code generated by ChatGPT, then tested and modified.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NOTE: sometimes the playareapoints get deleted- if you see the player floating in mid-air, this is the problem
// playAreaPoints
//GenericPropertyJSON:{"name":"playAreaPoints","type":-1,"arraySize":4,"arrayType":"Vector2","children":[{"name":"Array","type":-1,"arraySize":4,"arrayType":"Vector2","children":[{"name":"size","type":12,"val":4},{"name":"data","type":8,"children":[{"name":"x","type":2,"val":-3.5},{"name":"y","type":2,"val":-1.5}]},{"name":"data","type":8,"children":[{"name":"x","type":2,"val":3.5},{"name":"y","type":2,"val":-1.5}]},{"name":"data","type":8,"children":[{"name":"x","type":2,"val":4.5},{"name":"y","type":2,"val":-3}]},{"name":"data","type":8,"children":[{"name":"x","type":2,"val":-4.5},{"name":"y","type":2,"val":-3}]}]}]}

public class PlayerMovementOld : MonoBehaviour
{
    public float speed = 5f;
    public Color playAreaColor = Color.green;
    public Vector2[] playAreaPoints;

    private Vector3 targetPosition;

    // public GameObject player;

    void Start()
    {
        // player = GameObject.FindWithTag("player");

        // Stops the player from going to the center of the screen upon running the game or switching to a new scene.
        targetPosition = this.transform.position;
    }

    // Draw play area in the editor
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
        // Get target position on mouse click
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Plane groundPlane = new Plane(Vector3.forward, Vector3.zero);
            float distance;
            if (groundPlane.Raycast(ray, out distance))
            {
                Vector3 hitPoint = ray.GetPoint(distance);
                targetPosition = new Vector3(hitPoint.x, hitPoint.y, transform.position.z);
            }
        }

        // Move towards target position if inside play area
        if (IsPointInsidePlayArea(targetPosition))
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            // player.transform.position = Vector3.MoveTowards(player.transform.position, targetPosition, speed * Time.deltaTime);
        }

        // Move towards closest point on play area edge if outside play area
        if (!IsPointInsidePlayArea(targetPosition))
        {
            Vector3 closestPoint = GetClosestPoint(targetPosition);
            transform.position = Vector3.MoveTowards(transform.position, closestPoint, speed * Time.deltaTime);
            // player.transform.position = Vector3.MoveTowards(player.transform.position, closestPoint, speed * Time.deltaTime);
        }
    }

    // Check if a point is inside the play area using the ray casting algorithm
    private bool IsPointInsidePlayArea(Vector3 point)
    {
        int intersectCount = 0;

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

    // Get the closest point on a play area edge to a given point
    private Vector3 GetClosestPoint(Vector3 point)
    {
        Vector3 closestPoint = Vector3.zero;
        float closestDistance = float.MaxValue;

        for (int i = 0; i < playAreaPoints.Length; i++)
        {
            int j = (i + 1) % playAreaPoints.Length;
            Vector3 edgeStart = playAreaPoints[i];
            Vector3 edgeEnd = playAreaPoints[j];
            Vector3 edgeClosestPoint = GetClosestPointOnEdge(point, edgeStart, edgeEnd);
            float distance = Vector3.Distance(point, edgeClosestPoint);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestPoint = edgeClosestPoint;
            }
        }

        return closestPoint;
    }

    private Vector3 GetClosestPointOnEdge(Vector3 point, Vector3 edgeStart, Vector3 edgeEnd)
    {
        Vector3 edgeDirection = edgeEnd - edgeStart;
        float edgeLength = edgeDirection.magnitude;
        edgeDirection /= edgeLength;
        Vector3 pointDirection = point - edgeStart;
        float dotProduct = Vector3.Dot(pointDirection, edgeDirection);

        if (dotProduct <= 0)
        {
            return edgeStart;
        }
        else if (dotProduct >= edgeLength)
        {
            return edgeEnd;
        }
        else
        {
            return edgeStart + edgeDirection * dotProduct;
        }
    }
}