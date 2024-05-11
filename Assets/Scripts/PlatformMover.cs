using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    //class for moving a platform
    public Transform[] positions;
    public float speed = 5f;
    private int currentPositionIndex = 0;
    private Transform targetPosition;

    void Start()
    {
        if (positions.Length > 0)
        {
            targetPosition = positions[0];
        }
    }

    void Update()
    {
        MoveToTarget();
    }

    void MoveToTarget()
    {
        if (transform.position != targetPosition.position)
        {
            Vector2 newPosition = Vector2.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
            transform.position = newPosition;
        }
        else
        {
            currentPositionIndex = (currentPositionIndex + 1) % positions.Length;
            targetPosition = positions[currentPositionIndex];
        }
    }
}
